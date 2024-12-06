using UnityEngine;

public class Claw : MonoBehaviour
{
    [SerializeField] private GrapplingHook GrapplingHookGun;
    [SerializeField] private GarbageCollector garbageCollector;
    [SerializeField] private GarbageSpawner garbageSpawner;

    private Vector3 leftRetractOrigin;
    private Vector3 rightRetractOrigin;

    private GrapplingHook.ClawState leftState;
    private GrapplingHook.ClawState rightState;

    private bool isLeftHooked;
    private bool isRightHooked;

    private GameObject hookedGarbage;

    private GameObject clawLeft;
    private GameObject clawRight;

    private class GarbageHitInfo
    {
        public Collider HitCollider { get; set; }
    }

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

        if (PredictCollision(out var hitInfo))
        {
            if (hitInfo.HitCollider.CompareTag("Garbage"))
            {
                HookGarbage(hitInfo.HitCollider.gameObject);
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

    // Only use this for garbage objects
    private bool PredictCollision(out GarbageHitInfo hitInfo)
    {
        hitInfo = null;
        var prediction = transform.position + GetComponent<Rigidbody>().velocity * Time.fixedDeltaTime;

        // Calculate the castRadius based on the Renderer's bounding box
        Bounds bounds = GetComponent<Renderer>().bounds;
        var castRadius = (bounds.extents.x + bounds.extents.y + bounds.extents.z) / 3f;

        // Check if the claw is already intersecting with the garbage object
        Collider[] intersectingColliders = Physics.OverlapSphere(transform.position, castRadius);
        if (intersectingColliders.Length > 0)
        {
            foreach (Collider intersectingCollider in intersectingColliders)
            {
                if (intersectingCollider.CompareTag("Garbage"))
                {
                    hitInfo = new GarbageHitInfo { HitCollider = intersectingCollider };
                    return true;
                }
            }
        }

        if (Physics.SphereCast(transform.position, castRadius, (prediction - transform.position).normalized, out var hit, Vector3.Distance(transform.position, prediction)))
        {
            if (hit.collider.CompareTag("Garbage"))
            {
                hitInfo = new GarbageHitInfo { HitCollider = hit.collider };
                return true;
            }
        }

        return false;
    }

    private void HookGarbage(GameObject garbageObject)
    {
        hookedGarbage = garbageObject;

        if (clawLeft && leftState == GrapplingHook.ClawState.Launching && !isLeftHooked)
        {
            FixedJoint fixedJoint = CreateFixedJoint(gameObject, garbageObject);
            GetComponent<Rigidbody>().isKinematic = true;
            isLeftHooked = true;
            GrapplingHookGun.SetLeftState(GrapplingHook.ClawState.Retracting);
            Garbage garbage = garbageObject.GetComponent<Garbage>();
            GrapplingHookGun.SetLeftRetractSpeed(garbage.GetRetractSpeed());
        }

        if (clawRight && rightState == GrapplingHook.ClawState.Launching && !isRightHooked)
        {
            FixedJoint fixedJoint = CreateFixedJoint(gameObject, garbageObject);
            GetComponent<Rigidbody>().isKinematic = true;
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
            garbageSpawner.GarbageDestroyed(garbage);
            garbageCollector.IncrementGarbageCount(garbage.GetPoints());
        }

        if (clawRight && isRightHooked && rightState == GrapplingHook.ClawState.Idle)
        {
            Destroy(GetComponent<FixedJoint>());
            Destroy(hookedGarbage);

            isRightHooked = false;
            Garbage garbage = hookedGarbage.GetComponent<Garbage>();
            garbageSpawner.GarbageDestroyed(garbage);
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