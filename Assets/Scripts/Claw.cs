using UnityEngine;

public class Claw : MonoBehaviour
{
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

    private void FixedUpdate()
    {
        leftState = GrapplingHookGun.GetLeftState();
        rightState = GrapplingHookGun.GetRightState();

        RaycastHit hit;

        if (PredictCollision(out hit))
        {
            if (hit.collider.CompareTag("Garbage"))
            { 
                HookGarbage(hit.collider.gameObject);
            }
        }
        
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

    private bool PredictCollision(out RaycastHit hit)
    {
        var prediction = transform.position + GetComponent<Rigidbody>().velocity * Time.fixedDeltaTime;

        // Calculate the castRadius based on the Renderer's bounding box
        Bounds bounds = GetComponent<Renderer>().bounds;
        var castRadius = (bounds.extents.x + bounds.extents.y + bounds.extents.z) / 3f;

        var layerMask = ~LayerMask.GetMask("Claw");

        if (Physics.SphereCast(transform.position, castRadius, (prediction - transform.position).normalized, out hit, Vector3.Distance(transform.position, prediction), layerMask))
        {
            return true;
        }

        return false;
    }

    private void HookGarbage(GameObject garbageObject)
    {
        if (clawLeft && leftState == GrapplingHook.ClawState.Launching && !isLeftHooked)
        {
            hookedGarbage = garbageObject;
            GetComponent<Rigidbody>().isKinematic = true;
            FixedJoint fixedJoint = CreateFixedJoint(gameObject, garbageObject);
            isLeftHooked = true;
            GrapplingHookGun.SetLeftState(GrapplingHook.ClawState.Retracting);
            Garbage garbage = garbageObject.GetComponent<Garbage>();
            GrapplingHookGun.SetLeftRetractSpeed(garbage.GetRetractSpeed());
        }

        if (clawRight && rightState == GrapplingHook.ClawState.Launching && !isRightHooked)
        {
            hookedGarbage = garbageObject;
            GetComponent<Rigidbody>().isKinematic = true;
            FixedJoint fixedJoint = CreateFixedJoint(gameObject, garbageObject);
            isRightHooked = true;
            GrapplingHookGun.SetRightState(GrapplingHook.ClawState.Retracting);
            Garbage garbage = garbageObject.GetComponent<Garbage>();
            GrapplingHookGun.SetRightRetractSpeed(garbage.GetRetractSpeed());
        }
    }

    private void GarbageDestroyer()
    {
        if (clawLeft && isLeftHooked && leftState == GrapplingHook.ClawState.Idle)
        {
            Destroy(GetComponent<FixedJoint>());
            Destroy(hookedGarbage);

            isLeftHooked = false;
            Garbage garbage = hookedGarbage.GetComponent<Garbage>();
            garbageCollector.IncrementGarbageCount(garbage.GetPoints());
        }

        if (clawRight && isRightHooked && rightState == GrapplingHook.ClawState.Idle)
        { 
            Destroy(GetComponent<FixedJoint>());
            Destroy(hookedGarbage);

            isRightHooked = false;
            Garbage garbage = hookedGarbage.GetComponent<Garbage>();
            garbageCollector.IncrementGarbageCount(garbage.GetPoints());
        }
    }

    private FixedJoint CreateFixedJoint(GameObject claw, GameObject targetObject)
    {
        FixedJoint fixedJoint = targetObject.AddComponent<FixedJoint>();
        fixedJoint.connectedBody = claw.GetComponent<Rigidbody>();
        return fixedJoint;
    }
}