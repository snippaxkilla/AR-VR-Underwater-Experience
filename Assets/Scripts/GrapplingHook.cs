using System.Linq;
using UnityEngine;

public class GrapplingHook : MonoBehaviour
{
    // We access these states from the claw script
    public enum ClawState
    {
        Idle,
        Launching,
        Retracting
    }

    [SerializeField] private Rigidbody clawLeft;
    [SerializeField] private Rigidbody clawRight;

    [Header("How much offset in front of the controller does my claw sit?")]
    [SerializeField] private float clawOffset;

    [SerializeField] private float maxDistance = 2f;
    [SerializeField] private float retractSpeed = 4f;
    [SerializeField] private float autoRetractAfterDelay = 3f;
    [SerializeField] private float forceMagnitude = 15f;
    [SerializeField] private float cooldown = 0.1f;

    [Header("Specify the buttons we want to use to shoot out hooks")] 
    [SerializeField] private OVRInput.RawButton[] leftButtons;
    [SerializeField] private OVRInput.RawButton[] rightButtons;

    private bool leftButtonHeld = false;
    private bool rightButtonHeld = false;

    private float leftCooldownTimer;
    private float rightCooldownTimer;

    private float leftAutoRetractTimer;
    private float rightAutoRetractTimer;

    private Vector3 leftRayFwd => OVRInput.GetLocalControllerRotation(OVRInput.Controller.LTouch) * Vector3.forward;
    private Vector3 rightRayFwd => OVRInput.GetLocalControllerRotation(OVRInput.Controller.RTouch) * Vector3.forward;

    private Vector3 leftInitialPosition => OVRInput.GetLocalControllerPosition(OVRInput.Controller.LTouch) + leftRayFwd * clawOffset;
    private Vector3 rightInitialPosition => OVRInput.GetLocalControllerPosition(OVRInput.Controller.RTouch) + rightRayFwd * clawOffset;

    // Start with the claws on idle
    private ClawState leftState = ClawState.Idle;
    private ClawState rightState = ClawState.Idle;

    private Vector3 leftRetractOrigin;
    private Vector3 rightRetractOrigin;

    private void Update()
    {
        if (leftCooldownTimer > 0f) leftCooldownTimer -= Time.deltaTime;
        if (rightCooldownTimer > 0f) rightCooldownTimer -= Time.deltaTime;

        DistanceChecker(clawLeft, ref leftState, ref leftRetractOrigin, leftInitialPosition, ref leftAutoRetractTimer);
        DistanceChecker(clawRight, ref rightState, ref rightRetractOrigin, rightInitialPosition, ref rightAutoRetractTimer);

        if (leftState == ClawState.Retracting)
        {
            clawLeft.transform.position = Vector3.MoveTowards(clawLeft.transform.position, leftInitialPosition, Time.deltaTime * retractSpeed);

            if (Vector3.Distance(clawLeft.transform.position, leftInitialPosition) <= 0.01f)
            {
                leftState = ClawState.Idle;
                clawLeft.isKinematic = true;
            }
        }

        if (rightState == ClawState.Retracting)
        {
            clawRight.transform.position = Vector3.MoveTowards(clawRight.transform.position, rightInitialPosition, Time.deltaTime * retractSpeed);

            if (Vector3.Distance(clawRight.transform.position, rightInitialPosition) <= 0.01f)
            {
                rightState = ClawState.Idle;
                clawRight.isKinematic = true;
            }
        }
    }

    // In the hooks we are adding force that's why we need to use FixedUpdate
    private void FixedUpdate()
    {
        ShootClaw(OVRInput.Controller.LTouch, leftButtons, clawLeft, leftRayFwd, leftInitialPosition, ref leftState, ref leftRetractOrigin, ref leftCooldownTimer, ref leftAutoRetractTimer, ref leftButtonHeld);
        ShootClaw(OVRInput.Controller.RTouch, rightButtons, clawRight, rightRayFwd, rightInitialPosition, ref rightState, ref rightRetractOrigin, ref rightCooldownTimer, ref rightAutoRetractTimer, ref rightButtonHeld);
    }

    // Make sure that Origin happens after shooting
    private void LateUpdate()
    {
        OriginUpdater(OVRInput.Controller.LTouch, clawLeft.transform, leftState, leftInitialPosition);
        OriginUpdater(OVRInput.Controller.RTouch, clawRight.transform, rightState, rightInitialPosition);
    }

    // Update the claw position in front of the controller and keep it there unless the claw is out
    private void OriginUpdater(OVRInput.Controller controller, Transform claw, ClawState state, Vector3 clawInitialPosition)
    {
        var controllerRotation = OVRInput.GetLocalControllerRotation(controller);

        if (state != ClawState.Idle) return;
        claw.position = clawInitialPosition;
        claw.rotation = controllerRotation;
    }

    // Add force to the claw to launch the claw forwards and keep track of it's current distance from claw to controller initial position
    private void ShootClaw(OVRInput.Controller controller, OVRInput.RawButton[] buttons, Rigidbody claw, Vector3 rayFwd, Vector3 clawInitialPosition,
        ref ClawState state, ref Vector3 retractOrigin, ref float cooldownTimer, ref float autoRetractTimer, ref bool buttonHeld)
    {
        var pressingButton = buttons.Any(button => OVRInput.Get(button, controller));

        if (pressingButton && state == ClawState.Idle && cooldownTimer <= 0f && !buttonHeld)
        {
            claw.transform.position = clawInitialPosition;
            claw.isKinematic = false;
            claw.velocity = Vector3.zero;

            claw.AddForce(rayFwd * forceMagnitude, ForceMode.Impulse);

            state = ClawState.Launching;
            cooldownTimer = cooldown;
            autoRetractTimer = autoRetractAfterDelay;
            buttonHeld = true;
        }

        if (!pressingButton)
        {
            buttonHeld = false;
        }

        if (state == ClawState.Launching)
        {
            autoRetractTimer -= Time.fixedDeltaTime;
        }

        else if (pressingButton && state == ClawState.Launching)
        {
            RetractClaw(claw, ref state, ref retractOrigin);
        }
    }

    public void RetractClaw(Rigidbody claw, ref ClawState state, ref Vector3 retractOrigin)
    {
        if (state == ClawState.Retracting)
        {
            return;
        }

        retractOrigin = claw.transform.position;
        claw.isKinematic = true;
        state = ClawState.Retracting;
    }

    // Check if the hooks have gone beyond the maximum distance and retract them separately if necessary
    private void DistanceChecker(Rigidbody claw, ref ClawState state, ref Vector3 retractOrigin,
        Vector3 clawInitialPosition, ref float autoRetractTimer)
    {
        if (Vector3.Distance(clawInitialPosition, claw.transform.position - claw.transform.forward * clawOffset) > maxDistance && state == ClawState.Launching)
        {
            RetractClaw(claw, ref state, ref retractOrigin);
        }
        if (autoRetractTimer <= 0f && state == ClawState.Launching)
        {
            RetractClaw(claw, ref state, ref retractOrigin);
        }
    }

    // Getters and Setters we want to use in other scripts
    public ClawState GetLeftState()
    {
        return leftState;
    }

    public void SetLeftState(ClawState newState)
    {
        leftState = newState;
    }

    public ClawState GetRightState()
    {
        return rightState;
    }

    public void SetRightState(ClawState newState)
    {
        rightState = newState;
    }

    public Rigidbody GetLeftRigidbody()
    {
        return clawLeft;
    }

    public Rigidbody GetRightRigidbody()
    {
        return clawRight;
    }
}