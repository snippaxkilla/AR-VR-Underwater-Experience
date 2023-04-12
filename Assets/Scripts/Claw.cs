using UnityEngine;

public class Claw : MonoBehaviour
{
    [SerializeField] private GameObject GroupedGarbage;
    [SerializeField] private GrapplingHook GrapplingHookGun;
    [SerializeField] private GarbageCollector garbageCollector;

    private Vector3 leftRetractOrigin;
    private Vector3 rightRetractOrigin;
    private GrapplingHook.ClawState clawState;

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
            if (clawLeft)
            {
                clawState = GrapplingHookGun.GetLeftState();
            }
            if (clawRight)
            {
                clawState = GrapplingHookGun.GetRightState();
            }

            if (clawState == GrapplingHook.ClawState.Launching)
            {
                hookedGarbage = other.gameObject;

                GetComponent<Rigidbody>().isKinematic = true;

                FixedJoint fixedJoint = CreateFixedJoint(gameObject, hookedGarbage);

                if (clawLeft)
                {
                    isLeftHooked = true;
                    GrapplingHookGun.SetLeftState(GrapplingHook.ClawState.Retracting);
                }

                if (clawRight)
                {
                    isRightHooked = true;
                    GrapplingHookGun.SetRightState(GrapplingHook.ClawState.Retracting);
                }
            }
        }
    }

    private void Update()
    {
        if (clawLeft)
        {
            clawState = GrapplingHookGun.GetLeftState();
        }
        if (clawRight)
        {
            clawState = GrapplingHookGun.GetRightState();
        }

        GarbageDestroyer();

        if (clawState == GrapplingHook.ClawState.Retracting)
        {
            if (clawLeft)
            {
                GrapplingHookGun.RetractClaw(GrapplingHookGun.GetLeftRigidbody(), ref clawState, ref leftRetractOrigin);
            }
            if (clawRight)
            {
                GrapplingHookGun.RetractClaw(GrapplingHookGun.GetRightRigidbody(), ref clawState, ref rightRetractOrigin);
            }
        }
    }

    private void GarbageDestroyer()
    {
        if (clawState == GrapplingHook.ClawState.Idle)
        {
            if (clawLeft && isLeftHooked)
            {
                Destroy(GetComponent<FixedJoint>());
                Destroy(hookedGarbage);

                isLeftHooked = false;
                garbageCollector.IncrementGarbageCount();
            }

            if (clawRight && isRightHooked)
            {
                Destroy(GetComponent<FixedJoint>());
                Destroy(hookedGarbage);

                isRightHooked = false;
                garbageCollector.IncrementGarbageCount();
            }
        }
    }

    private FixedJoint CreateFixedJoint(GameObject claw, GameObject targetObject)
    {
        FixedJoint fixedJoint = targetObject.AddComponent<FixedJoint>();
        fixedJoint.connectedBody = claw.GetComponent<Rigidbody>();
        return fixedJoint;
    }
}