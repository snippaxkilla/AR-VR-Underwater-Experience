using System.Collections;
using System.Linq;
using UnityEngine;

public class GrapplingHook : MonoBehaviour
{
    private enum ClawState
    {
        Idle,
        Launched,
        Retracting
    }

    [SerializeField] private Rigidbody clawLeft;
    [SerializeField] private Rigidbody clawRight;

    [Header("How much offset in front of the controller does my claw sit?")]
    [SerializeField] private float clawOffset;

    [SerializeField] private float maxDistance = 2f;
    [SerializeField] private float retractTime = 0.2f;
    [SerializeField] private float autoRetractAfterDelay = 5f;
    [SerializeField] private float forceMagnitude = 15f;

    [Header("Specify the buttons we want to use to shoot out hooks")] 
    [SerializeField] private OVRInput.RawButton[] leftButtons;
    [SerializeField] private OVRInput.RawButton[] rightButtons;

    private Vector3 leftRayFwd => OVRInput.GetLocalControllerRotation(OVRInput.Controller.LTouch) * Vector3.forward;
    private Vector3 rightRayFwd => OVRInput.GetLocalControllerRotation(OVRInput.Controller.RTouch) * Vector3.forward;

    private Vector3 clawLeftInitialPosition => OVRInput.GetLocalControllerPosition(OVRInput.Controller.LTouch) + leftRayFwd * clawOffset;
    private Vector3 clawRightInitialPosition => OVRInput.GetLocalControllerPosition(OVRInput.Controller.RTouch) + rightRayFwd * clawOffset;

    // Start with the claws on idle
    private ClawState clawLeftState = ClawState.Idle;
    private ClawState clawRightState = ClawState.Idle;

    private Vector3 leftClawRetractOrigin;
    private Vector3 rightClawRetractOrigin;

    private float leftClawRetractTime;
    private float rightClawRetractTime;

    private void Update()
    {
        DistanceChecker(clawLeft, ref clawLeftState, ref leftClawRetractOrigin, clawLeftInitialPosition);
        DistanceChecker(clawRight, ref clawRightState, ref rightClawRetractOrigin, clawRightInitialPosition);

        if (clawLeftState == ClawState.Retracting)
        {
            leftClawRetractTime += Time.deltaTime;
            clawLeft.transform.position = Vector3.Lerp(leftClawRetractOrigin, clawLeftInitialPosition, leftClawRetractTime / retractTime);
            if (leftClawRetractTime >= retractTime)
            {
                clawLeftState = ClawState.Idle;
                leftClawRetractTime = 0;
                clawLeft.isKinematic = true;
            }
        }
        
        if (clawRightState == ClawState.Retracting)
        {
            rightClawRetractTime += Time.deltaTime;
            clawRight.transform.position = Vector3.Lerp(rightClawRetractOrigin, clawRightInitialPosition, rightClawRetractTime / retractTime);
            if (rightClawRetractTime >= retractTime)
            {
                clawRightState = ClawState.Idle;
                rightClawRetractTime = 0;
                clawRight.isKinematic = true;
            }
        }
    }

    // In the hooks we are adding force that's why we need to use FixedUpdate
    private void FixedUpdate()
    {
        ShootClaw(OVRInput.Controller.LTouch, leftButtons, clawLeft, leftRayFwd, clawLeftInitialPosition, ref clawLeftState, ref leftClawRetractOrigin);
        ShootClaw(OVRInput.Controller.RTouch, rightButtons, clawRight, rightRayFwd, clawRightInitialPosition, ref clawRightState, ref rightClawRetractOrigin);
    }

    // Make sure that Origin happens after shooting
    private void LateUpdate()
    {
        OriginUpdater(OVRInput.Controller.LTouch, clawLeft.transform, clawLeftState, clawLeftInitialPosition);
        OriginUpdater(OVRInput.Controller.RTouch, clawRight.transform, clawRightState, clawRightInitialPosition);
    }

    // Update the claw position in front of the controller and keep it there unless the claw is out
    private void OriginUpdater(OVRInput.Controller controller, Transform claw, ClawState state, Vector3 clawInitialPosition)
    {
        var controllerRotation = OVRInput.GetLocalControllerRotation(controller);

        if (state == ClawState.Idle)
        {
            claw.position = clawInitialPosition;
            claw.rotation = controllerRotation;
        }
    }

    // Add force to the claw to launch the claw forwards and keep track of it's current distance from claw to controller initial position
    private void ShootClaw(OVRInput.Controller controller, OVRInput.RawButton[] buttons, Rigidbody claw, Vector3 rayFwd, Vector3 clawInitialPosition,
        ref ClawState state, ref Vector3 retractOrigin)
    {
        var pressingButton = buttons.Any(button => OVRInput.GetDown(button, controller));

        if (pressingButton && state == ClawState.Idle)
        {
            claw.transform.position = clawInitialPosition;
            claw.isKinematic = false;
            claw.velocity = Vector3.zero;

            claw.AddForce(rayFwd * forceMagnitude, ForceMode.Impulse);

            state = ClawState.Launched;
        }

        else if (pressingButton && state == ClawState.Launched)
        {
            RetractClaw(claw, ref state, ref retractOrigin);
        }
    }

    private void RetractClaw(Rigidbody claw, ref ClawState state, ref Vector3 retractOrigin)
    {
        retractOrigin = claw.transform.position;
        claw.isKinematic = true;
        state = ClawState.Retracting;
    }

    // Check if the hooks have gone beyond the maximum distance and retract them separately if necessary
    private void DistanceChecker(Rigidbody claw, ref ClawState state, ref Vector3 retractOrigin,
        Vector3 clawInitialPosition)
    {
        if (Vector3.Distance(clawInitialPosition, claw.transform.position - claw.transform.forward * clawOffset) >
            maxDistance && state == ClawState.Launched)
        {
            RetractClaw(claw, ref state, ref retractOrigin);
        }
    }
}