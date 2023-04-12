using UnityEngine;

public class Claw : MonoBehaviour
{
    [SerializeField] private GameObject GroupedGarbage;

    private GrapplingHook GrapplingHookGun;
    private GarbageCollector garbageCollector;

    private Vector3 leftRetractOrigin;
    private Vector3 rightRetractOrigin;
    private GrapplingHook.ClawState clawState;

    private bool isHooked;
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

    // Whenever we hit any garbage we will create a fixed joint and set our state to retracting
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
                isHooked = true;

                GetComponent<Rigidbody>().isKinematic = true;

                FixedJoint fixedJoint = CreateFixedJoint(gameObject, hookedGarbage);

                if (clawLeft)
                {
                    GrapplingHookGun.SetLeftState(GrapplingHook.ClawState.Retracting);
                }

                if (clawRight)
                {
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

    // If we are retracting and we are close enough to the origin we will destroy the fixed joint and our garbage
    private void GarbageDestroyer()
    {
        if (clawState == GrapplingHook.ClawState.Idle && isHooked)
        {
            Destroy(GetComponent<FixedJoint>());
            Destroy(hookedGarbage);

            isHooked = false;
            garbageCollector.IncrementGarbageCount();
        }
    }

    // FixedJoint between claw and garbage
    private FixedJoint CreateFixedJoint(GameObject claw, GameObject targetObject)
    {
        FixedJoint fixedJoint = targetObject.AddComponent<FixedJoint>();
        fixedJoint.connectedBody = claw.GetComponent<Rigidbody>();
        return fixedJoint;
    }
}