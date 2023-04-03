using System.Collections;
using System.Linq;
using UnityEngine;

public class GrapplingHook : MonoBehaviour
{
    [SerializeField] private GameObject clawLeft;
    [SerializeField] private GameObject clawRight;
    [SerializeField] private float maxDistance = 10f;
    [SerializeField] private float pullSpeed = 5f;
    [SerializeField] private float forceMagnitude = 15f;

    [Header("Specify the buttons we want to use to shoot out hooks")] [SerializeField]
    private OVRInput.RawButton[] leftButtons;

    [SerializeField] private OVRInput.RawButton[] rightButtons;

    private Vector3 clawLeftInitialPosition;
    private Vector3 clawRightInitialPosition;
    private float clawLeftCurrentDistance;
    private float clawRightCurrentDistance;
    private bool isLeftRetracting = false;
    private bool isRightRetracting = false;

    // Set the initial position of the claws to the controllers position
    private void Start()
    {
        clawLeftInitialPosition = OVRInput.GetLocalControllerPosition(OVRInput.Controller.LTouch);
        clawRightInitialPosition = OVRInput.GetLocalControllerPosition(OVRInput.Controller.RTouch);
    }

    // In the hooks we are adding force that's why we need to use FixedUpdate
    private void FixedUpdate()
    {
        ShootHook(OVRInput.Controller.LTouch, leftButtons, clawLeft, ref isLeftRetracting, clawLeftInitialPosition,
            ref clawLeftCurrentDistance);
        ShootHook(OVRInput.Controller.RTouch, rightButtons, clawRight, ref isRightRetracting, clawRightInitialPosition,
            ref clawRightCurrentDistance);
    }

    // Add force to the claw to launch the claw forwards and keep track of it's current distance from claw to controller initial position
    private void ShootHook(OVRInput.Controller controller, OVRInput.RawButton[] buttons, GameObject claw,
        ref bool isRetracting, Vector3 clawInitialPosition, ref float clawCurrentDistance)
    {
        var clawRigidbody = claw.GetComponent<Rigidbody>();

        var rayFwd = OVRInput.GetLocalControllerRotation(controller) * Vector3.forward;

        var pressingButton = buttons.Any(button => OVRInput.GetDown(button, controller));

        if (!pressingButton || isRetracting) return;

        if (clawCurrentDistance >= maxDistance)
        {
            DistanceChecker();
            return;
        }

        claw.transform.position = clawInitialPosition;
        clawRigidbody.AddForce(rayFwd * forceMagnitude, ForceMode.Impulse);

        clawCurrentDistance = Vector3.Distance(transform.position, claw.transform.position);

        if (clawCurrentDistance >= maxDistance)
        {
            DistanceChecker();
        }
    }

    public IEnumerator RetractHook(GameObject claw, Vector3 clawInitialPosition)
    {
        var lerpStartTime = Time.time;

        while (Vector3.Distance(claw.transform.position, clawInitialPosition) > 0.01f)
        {
            var lerpFactor = (Time.time - lerpStartTime) / pullSpeed;
            claw.transform.position = Vector3.Lerp(claw.transform.position, clawInitialPosition, lerpFactor);
            yield return null;
        }

        claw.transform.position = clawInitialPosition;
    }

    // Check if the hooks have gone beyond the maximum distance and retract them if necessary
    private void DistanceChecker()
    {
        if (Vector3.Distance(transform.position, clawLeft.transform.position) > maxDistance && !isLeftRetracting)
        {
            isLeftRetracting = true;
            StartCoroutine(RetractHook(clawLeft, clawLeftInitialPosition));
        }

        if (Vector3.Distance(transform.position, clawRight.transform.position) > maxDistance && !isRightRetracting)
        {
            isRightRetracting = true;
            StartCoroutine(RetractHook(clawRight, clawRightInitialPosition));
        }
    }
}