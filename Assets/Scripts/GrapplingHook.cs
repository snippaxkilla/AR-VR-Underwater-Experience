using System.Collections;
using System.Linq;
using UnityEngine;

public class GrapplingHook : MonoBehaviour
{
    public enum ClawState
    {
        Idle,
        Launched,
        Retracting
    }

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

    // Ref values
    private float clawLeftCurrentDistance;
    private float clawRightCurrentDistance;

    // Start with the claws on idle
    private ClawState clawLeftState = ClawState.Idle;
    private ClawState clawRightState = ClawState.Idle;

    private void Update()
    {
        DistanceChecker(clawLeft, ref clawLeftState, clawLeftInitialPosition);
        DistanceChecker(clawRight, ref clawRightState, clawRightInitialPosition);
    }

    // In the hooks we are adding force that's why we need to use FixedUpdate
    private void FixedUpdate()
    {
        ShootClaw(OVRInput.Controller.LTouch, leftButtons, clawLeft, ref clawLeftState, clawLeftInitialPosition,
            ref clawLeftCurrentDistance);
        ShootClaw(OVRInput.Controller.RTouch, rightButtons, clawRight, ref clawRightState, clawRightInitialPosition,
            ref clawRightCurrentDistance);
    }

    // Make sure that Origin happens after shooting
    private void LateUpdate()
    {
        OriginUpdater(OVRInput.Controller.LTouch, clawLeft, ref clawLeftState);
        OriginUpdater(OVRInput.Controller.RTouch, clawRight, ref clawRightState);
    }

    // Update the claw position in front of the controller and keep it there unless the claw is out
    private void OriginUpdater(OVRInput.Controller controller, GameObject claw, ref ClawState state)
    {
        var controllerForward = OVRInput.GetLocalControllerRotation(controller) * Vector3.forward;
        var controllerRotation = OVRInput.GetLocalControllerRotation(controller);
        var clawInitialPosition = OVRInput.GetLocalControllerPosition(controller) + controllerForward * clawOffset;
        var clawRigidbody = claw.GetComponent<Rigidbody>();

        claw.transform.rotation = controllerRotation;

        switch (state)
        {
            case ClawState.Idle:
                clawRigidbody.isKinematic = true;
                claw.transform.position = clawInitialPosition;
                break;
            case ClawState.Launched:
                clawRigidbody.isKinematic = false;
                break;
            case ClawState.Retracting:
                clawRigidbody.isKinematic = true;
                break;
        }
    }

    // Add force to the claw to launch the claw forwards and keep track of it's current distance from claw to controller initial position
    private IEnumerator RetractClawCoroutine;

    private void ShootClaw(OVRInput.Controller controller, OVRInput.RawButton[] buttons, GameObject claw,
        ref ClawState state, Vector3 clawInitialPosition, ref float clawCurrentDistance)
    {
        var clawRigidbody = claw.GetComponent<Rigidbody>();

        var rayFwd = OVRInput.GetLocalControllerRotation(controller) * Vector3.forward;

        var pressingButton = buttons.Any(button => OVRInput.GetDown(button, controller));

        if (!pressingButton || state == ClawState.Retracting || RetractClawCoroutine != null) return;

        claw.transform.position = clawInitialPosition;

        state = ClawState.Launched;

        clawRigidbody.AddForce(rayFwd * forceMagnitude, ForceMode.Impulse);

        clawCurrentDistance = Vector3.Distance(clawInitialPosition, claw.transform.position);

        // Start retracting the claw if it goes beyond the maximum distance
        if (clawCurrentDistance >= maxDistance)
        {
            state = ClawState.Retracting;
            RetractClawCoroutine = RetractClaw(claw, clawInitialPosition);
            StartCoroutine(RetractClawCoroutine);
        }
    }

    // Use an IEnumerator to lerp the claw back to it's initial position
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
        RetractClawCoroutine = null;
    }

    // Check if the hooks have gone beyond the maximum distance and retract them separately if necessary
    private void DistanceChecker(GameObject claw, ref ClawState state, Vector3 clawInitialPosition)
    {
        if (Vector3.Distance(clawInitialPosition, claw.transform.position - claw.transform.forward * clawOffset) > maxDistance && state == ClawState.Launched)
        {
            state = ClawState.Retracting;
            StartCoroutine(RetractClaw(claw, clawInitialPosition));
            state = ClawState.Idle;
        }
    }
}