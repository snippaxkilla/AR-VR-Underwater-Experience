using System.Collections;
using System.Linq;
using UnityEngine;

public class GrapplingHook : MonoBehaviour
{
    [SerializeField] private GameObject clawLeft;
    [SerializeField] private GameObject clawRight;
    [SerializeField] private Vector3 clawOffset;

    [SerializeField] private float maxDistance = 2f;
    [SerializeField] private float pullSpeed = 1f;
    [SerializeField] private float forceMagnitude = 15f;

    [Header("Specify the buttons we want to use to shoot out hooks")] 
    [SerializeField] private OVRInput.RawButton[] leftButtons;
    [SerializeField] private OVRInput.RawButton[] rightButtons;

    private Vector3 clawLeftInitialPosition;
    private Vector3 clawRightInitialPosition;
    private float clawLeftCurrentDistance;
    private float clawRightCurrentDistance;
    private bool isLeftRetracting;
    private bool isRightRetracting;

    private void Update()
    {
        OriginUpdater();
        DistanceChecker();
    }

    private void OriginUpdater()
    {
        clawLeftInitialPosition = OVRInput.GetLocalControllerPosition(OVRInput.Controller.LTouch) + clawOffset;
        clawRightInitialPosition = OVRInput.GetLocalControllerPosition(OVRInput.Controller.RTouch) + clawOffset;

        clawLeftInitialPosition = clawLeft.transform.position;
        clawRightInitialPosition = clawRight.transform.position;

        if (!isLeftRetracting)
        {
            clawLeft.transform.position = clawLeftInitialPosition;
            clawLeft.GetComponent<Rigidbody>().isKinematic = true;
        }

        if (!isRightRetracting)
        {
            clawRight.transform.position = clawRightInitialPosition;
            clawRight.GetComponent<Rigidbody>().isKinematic = true;
        }
    }

    // In the hooks we are adding force that's why we need to use FixedUpdate
    private void FixedUpdate()
    {
        ShootClaw(OVRInput.Controller.LTouch, leftButtons, clawLeft, ref isLeftRetracting, clawLeftInitialPosition,
            ref clawLeftCurrentDistance, false);
        ShootClaw(OVRInput.Controller.RTouch, rightButtons, clawRight, ref isRightRetracting, clawRightInitialPosition,
            ref clawRightCurrentDistance, false);

    }

    // Add force to the claw to launch the claw forwards and keep track of it's current distance from claw to controller initial position
    private void ShootClaw(OVRInput.Controller controller, OVRInput.RawButton[] buttons, GameObject claw,
        ref bool isRetracting, Vector3 clawInitialPosition, ref float clawCurrentDistance, bool isLaunching)
    {
        var clawRigidbody = claw.GetComponent<Rigidbody>();

        var rayFwd = OVRInput.GetLocalControllerRotation(controller) * Vector3.forward;

        var pressingButton = buttons.Any(button => OVRInput.GetDown(button, controller));

        if (!pressingButton || isRetracting) return;

        claw.transform.position = clawInitialPosition;
        clawRigidbody.isKinematic = isRetracting;
        clawRigidbody.AddForce(rayFwd * forceMagnitude, ForceMode.Impulse);

        clawCurrentDistance = Vector3.Distance(transform.position, claw.transform.position);
    }

    public IEnumerator RetractClaw(GameObject claw, Vector3 clawInitialPosition)
    {
        claw.GetComponent<Rigidbody>().isKinematic = true;

        var lerpStartTime = Time.time;

        while (Vector3.Distance(claw.transform.position, clawInitialPosition) > 0.1f)
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
            StartCoroutine(RetractClaw(clawLeft, clawLeftInitialPosition));
            isLeftRetracting = false;
        }

        if (Vector3.Distance(transform.position, clawRight.transform.position) > maxDistance && !isRightRetracting)
        {
            isRightRetracting = true;
            StartCoroutine(RetractClaw(clawRight, clawRightInitialPosition));
            isRightRetracting = false;
        }
    }
}