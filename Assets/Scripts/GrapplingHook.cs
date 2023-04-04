using System.Collections;
using System.Linq;
using UnityEngine;

public class GrapplingHook : MonoBehaviour
{
    [SerializeField] private GameObject clawLeft;
    [SerializeField] private GameObject clawRight;
    [SerializeField] private float clawOffset;

    [SerializeField] private float maxDistance = 2f;
    [SerializeField] private float pullSpeed = 0.2f;
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
        OriginUpdater(OVRInput.Controller.LTouch, clawLeft);
        OriginUpdater(OVRInput.Controller.RTouch, clawRight);

        DistanceChecker();
    }

    // When the claw is in front of the controller we don't want it to be able to be moved with physics so we set it's kinematic to true
    private void OriginUpdater(OVRInput.Controller controller, GameObject claw)
    {
        var controllerForward = OVRInput.GetLocalControllerRotation(controller) * Vector3.forward;
        var clawInitialPosition = OVRInput.GetLocalControllerPosition(controller) + controllerForward * clawOffset;
        claw.transform.position = clawInitialPosition;
        var clawRigidbody = claw.GetComponent<Rigidbody>();

        if (!clawRigidbody.isKinematic && Vector3.Distance(claw.transform.position,clawInitialPosition) < 0.1f)
        {
            clawRigidbody.isKinematic = true;
        }
        else if (clawRigidbody.isKinematic && Vector3.Distance(claw.transform.position, clawInitialPosition) >= 0.1f)
        {
            clawRigidbody.isKinematic = false;
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
    private IEnumerator RetractClawCoroutine;

    private void ShootClaw(OVRInput.Controller controller, OVRInput.RawButton[] buttons, GameObject claw,
        ref bool isRetracting, Vector3 clawInitialPosition, ref float clawCurrentDistance, bool isLaunching)
    {
        var clawRigidbody = claw.GetComponent<Rigidbody>();

        var rayFwd = OVRInput.GetLocalControllerRotation(controller) * Vector3.forward;

        var pressingButton = buttons.Any(button => OVRInput.GetDown(button, controller));

        if (!pressingButton || isRetracting || RetractClawCoroutine != null) return;

        claw.transform.position = clawInitialPosition;
        clawRigidbody.isKinematic = false;
        clawRigidbody.AddForce(rayFwd * forceMagnitude, ForceMode.Impulse);

        clawCurrentDistance = Vector3.Distance(clawInitialPosition, claw.transform.position);

        // Start retracting the claw if it goes beyond the maximum distance
        if (clawCurrentDistance >= maxDistance)
        {
            isRetracting = true;
            RetractClawCoroutine = RetractClaw(claw, clawInitialPosition);
            StartCoroutine(RetractClawCoroutine);
        }
    }

    // Use an IEnumerator to lerp the claw back to it's initial position
    public IEnumerator RetractClaw(GameObject claw, Vector3 clawInitialPosition)
    {
        claw.GetComponent<Rigidbody>().isKinematic = true;

        var lerpStartTime = Time.fixedDeltaTime;

        while (Vector3.Distance(claw.transform.position, clawInitialPosition) > 0.1f)
        {
            var lerpFactor = (Time.fixedDeltaTime - lerpStartTime) / pullSpeed;
            claw.transform.position = Vector3.Lerp(claw.transform.position, clawInitialPosition, lerpFactor);
            yield return null;
        }
        claw.transform.position = clawInitialPosition;
        RetractClawCoroutine = null;
    }

    // Check if the hooks have gone beyond the maximum distance and retract them separately if necessary
    private void DistanceChecker()
    {
        if (Vector3.Distance(transform.position, clawLeft.transform.position - clawLeft.transform.forward * clawOffset) > maxDistance && !isLeftRetracting)
        {
            isLeftRetracting = true;
            StartCoroutine(RetractClaw(clawLeft, clawLeftInitialPosition));
            isLeftRetracting = false;
        }

        if (Vector3.Distance(transform.position, clawRight.transform.position - clawRight.transform.forward * clawOffset) > maxDistance && !isRightRetracting)
        {
            isRightRetracting = true;
            StartCoroutine(RetractClaw(clawRight, clawRightInitialPosition));
            isRightRetracting = false;
        }
    }
}