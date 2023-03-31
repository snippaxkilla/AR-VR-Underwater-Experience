using System.Linq;
using UnityEngine;

public class GrapplingHook : MonoBehaviour
{
    [SerializeField] private GameObject clawLeft;
    [SerializeField] private GameObject clawRight;
    [SerializeField] private float maxDistance = 10f;
    [SerializeField] private float pullSpeed = 5f;
    [SerializeField] private float forceMagnitude = 15f;

    [Header("Specify the buttons we want to use to shoot out hooks")]
    [SerializeField] private OVRInput.RawButton[] leftButtons;
    [SerializeField] private OVRInput.RawButton[] rightButtons;

    private Vector3 clawLeftInitialPosition;
    private Vector3 clawRightInitialPosition;
    private float clawLeftCurrentDistance;
    private float clawRightCurrentDistance;
    private bool isLeftRetracting = false;
    private bool isRightRetracting = false;
    private float leftLerpStartTime;
    private float rightLerpStartTime;

    // Set the initial position of the claws to the controllers position
    private void Start()
    {
        clawLeftInitialPosition = OVRInput.GetLocalControllerPosition(OVRInput.Controller.LTouch);
        clawRightInitialPosition = OVRInput.GetLocalControllerPosition(OVRInput.Controller.RTouch);
    }

    private void Update()
    {
        DistanceChecker();
       
    }

    // In the hooks we are adding force that's why we need to use FixedUpdate
    private void FixedUpdate()
    {
        ShootHook(OVRInput.Controller.LTouch, leftButtons, clawLeft, ref isLeftRetracting, ref leftLerpStartTime, clawLeftInitialPosition, ref clawLeftCurrentDistance);
        ShootHook(OVRInput.Controller.RTouch, rightButtons, clawRight, ref isRightRetracting, ref rightLerpStartTime, clawRightInitialPosition, ref clawRightCurrentDistance);
    }

    // Add force to the claw to launch the claw forwards and keep track of it's current distance from claw to controller initial position
    private void ShootHook(OVRInput.Controller controller, OVRInput.RawButton[] buttons, GameObject claw,
        ref bool isRetracting, ref float lerpStartTime, Vector3 clawInitialPosition, ref float clawCurrentDistance)
    {
        var clawRigidbody = claw.GetComponent<Rigidbody>();

        var rayFwd = OVRInput.GetLocalControllerRotation(controller) * Vector3.forward;

        var pressingButton = buttons.Any(button => OVRInput.GetDown(button, controller));

        if (!pressingButton) return;
        claw.transform.position = clawInitialPosition;
        clawRigidbody.AddForce(rayFwd * forceMagnitude, ForceMode.Impulse);

        isRetracting = false;
        clawCurrentDistance = Vector3.Distance(transform.position, claw.transform.position);
    }

    // Retract the hook back to it's original position
    public void RetractHook(GameObject claw, Vector3 clawInitialPosition)
    {
        var lerpStartTime = Time.time;
        var timeElapsed = 0f;

        while (timeElapsed < pullSpeed)
        {
            var lerpFactor = timeElapsed / pullSpeed;
            lerpFactor = Mathf.Clamp01(lerpFactor);
            claw.transform.position = Vector3.Lerp(claw.transform.position, clawInitialPosition, lerpFactor);

            timeElapsed = Time.time - lerpStartTime;
        }

        claw.transform.position = clawInitialPosition;
    }

    // Don't let the claw go past the max distance
    private void DistanceChecker()
    {
        if (clawLeftCurrentDistance >= maxDistance)
        {
            RetractHook(clawLeft, clawLeftInitialPosition);
        }

        if (clawRightCurrentDistance >= maxDistance)
        {
            RetractHook(clawRight, clawRightInitialPosition);
        }
    }
}