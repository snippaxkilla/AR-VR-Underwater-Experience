using UnityEngine;

public class Claw : MonoBehaviour
{
    [SerializeField] private GameObject GroupedGarbage;
    [SerializeField] private GrapplingHook GrapplingHookGun;
    [SerializeField] private GarbageCollector garbageCollector;

    private Vector3 leftRetractOrigin;
    private Vector3 rightRetractOrigin;
    private GrapplingHook.ClawState clawState;

    private bool isHooked;
    private GameObject hookedGarbage;

    // Whenever we hit any garbage we will create a fixed joint and set our state to retracting
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.parent != null && other.transform.parent.gameObject == GroupedGarbage)
        {
            hookedGarbage = other.gameObject;
            isHooked = true;

            GetComponent<Rigidbody>().isKinematic = true;

            FixedJoint fixedJoint = CreateFixedJoint(gameObject, hookedGarbage);

            if (transform.name == "ClawLeft")
            {
                GrapplingHookGun.SetLeftState(GrapplingHook.ClawState.Retracting);
            }

            if (transform.name == "ClawRight")
            {
                GrapplingHookGun.SetRightState(GrapplingHook.ClawState.Retracting);
            }
        }
    }

    private void Update()
    {
        if (transform.name == "ClawLeft")
        {
            clawState = GrapplingHookGun.GetLeftState();
        }
        if (transform.name == "ClawRight")
        {
            clawState = GrapplingHookGun.GetRightState();
        }

        GarbageDestroyer();

        if (clawState == GrapplingHook.ClawState.Retracting)
        {
            if (transform.name == "ClawLeft")
            {
                GrapplingHookGun.RetractClaw(GrapplingHookGun.GetLeftRigidbody(), ref clawState, ref leftRetractOrigin);
            }
            if (transform.name == "ClawRight")
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