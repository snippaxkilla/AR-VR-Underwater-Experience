using UnityEngine;

public class Claw : MonoBehaviour
{
    [SerializeField] private GameObject GroupedGarbage;
    [SerializeField] private GrapplingHook GrapplingHookGun;

    [SerializeField] private GarbageCollector garbageCollector;

    // Ref values we need for retracting the claw
    private Vector3 leftRetractOrigin;
    private Vector3 rightRetractOrigin;
    private GrapplingHook.ClawState clawState;

    private bool isHooked;
    private GameObject hookedGarbage;

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.parent != null && other.transform.parent.gameObject == GroupedGarbage)
        {
            hookedGarbage = other.gameObject;
            isHooked = true;

            FixedJoint fixedJoint = CreateFixedJoint(gameObject, hookedGarbage);

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

    private void Update()
    {
        GarbageDestroyer();
    }

    // Destroy the garbage when the claw is retracted so the claw state is idle
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

    private FixedJoint CreateFixedJoint(GameObject claw, GameObject targetObject)
    {
        FixedJoint fixedJoint = targetObject.AddComponent<FixedJoint>();
        fixedJoint.connectedBody = claw.GetComponent<Rigidbody>();
        return fixedJoint;
    }
}