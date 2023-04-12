using UnityEngine;

public class Claw : MonoBehaviour
{
    [SerializeField] private GameObject GroupedGarbage;

    [SerializeField] private GrapplingHook GrapplingHookGun;
    [SerializeField] private GarbageCollector garbageCollector;

    private Vector3 leftRetractOrigin;
    private Vector3 rightRetractOrigin;

    private GrapplingHook.ClawState leftState;
    private GrapplingHook.ClawState rightState;

    private bool isLeftHooked;
    private bool isRightHooked;
    private GameObject hookedGarbage;

    private GameObject clawLeft;
    private GameObject clawRight;

    private void Start()
    {
        if (transform.name == "ClawLeft")
        {
            clawLeft = gameObject;
        }

        if (transform.name == "ClawRight")
        {
            clawRight = gameObject;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.parent != null && other.transform.parent.gameObject == GroupedGarbage)
        {
            hookedGarbage = other.gameObject;

            if (clawLeft && leftState == GrapplingHook.ClawState.Launching && !isLeftHooked)
            { 
                isLeftHooked = true;
                GrapplingHookGun.SetLeftState(GrapplingHook.ClawState.Retracting);
                GetComponent<Rigidbody>().isKinematic = true;
                FixedJoint fixedJoint = CreateFixedJoint(gameObject, hookedGarbage);
            }

            if (clawRight && rightState == GrapplingHook.ClawState.Launching && !isRightHooked)
            { 
                isRightHooked = true; 
                GrapplingHookGun.SetRightState(GrapplingHook.ClawState.Retracting);
                GetComponent<Rigidbody>().isKinematic = true;
                FixedJoint fixedJoint = CreateFixedJoint(gameObject, hookedGarbage);
            }
        }
    }

    private void FixedUpdate()
    {
        leftState = GrapplingHookGun.GetLeftState();
        rightState = GrapplingHookGun.GetRightState();
        
        GarbageDestroyer();

        if (clawLeft && leftState == GrapplingHook.ClawState.Retracting)
        {
            GrapplingHookGun.RetractClaw(GrapplingHookGun.GetLeftRigidbody(), ref leftState, ref leftRetractOrigin);
        }

        if (clawRight && rightState == GrapplingHook.ClawState.Retracting)
        {
            GrapplingHookGun.RetractClaw(GrapplingHookGun.GetRightRigidbody(), ref rightState, ref rightRetractOrigin);
        }
    }

    private void GarbageDestroyer()
    {
        if (clawLeft && isLeftHooked && leftState == GrapplingHook.ClawState.Idle)
        {
            Destroy(GetComponent<FixedJoint>());
            Destroy(hookedGarbage);

            isLeftHooked = false;
            garbageCollector.IncrementGarbageCount();
        }

        if (clawRight && isRightHooked && rightState == GrapplingHook.ClawState.Idle)
        { 
            Destroy(GetComponent<FixedJoint>());
            Destroy(hookedGarbage);

            isRightHooked = false;
            garbageCollector.IncrementGarbageCount();
        }
    }

    private FixedJoint CreateFixedJoint(GameObject claw, GameObject targetObject)
    {
        FixedJoint fixedJoint = targetObject.AddComponent<FixedJoint>();
        fixedJoint.connectedBody = claw.GetComponent<Rigidbody>();
        return fixedJoint;
    }
}