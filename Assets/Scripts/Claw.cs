using UnityEngine;

public class Claw : MonoBehaviour
{
    [SerializeField] private GameObject GroupedGarbage;
    [SerializeField] private GrapplingHook GrapplingHookGun;

    // Ref values we need for retracting the claw
    [SerializeField] private Vector3 leftRetractOrigin;
    [SerializeField] private Vector3 rightRetractOrigin;
    private GrapplingHook.ClawState leftState;
    private GrapplingHook.ClawState rightState;

    private bool isHooked;
    private GameObject hookedGarbage;

    private void OnTriggerEnter(Collider other)
    {
        hookedGarbage = other.gameObject;
        isHooked = true;

        if (transform.name == "ClawLeft")
        { 
            GrapplingHookGun.RetractClaw(GrapplingHookGun.GetLeftRigidbody(), ref leftState, ref leftRetractOrigin);
        }
        if (transform.name == "ClawRight")
        { 
            GrapplingHookGun.RetractClaw(GrapplingHookGun.GetRightRigidbody(), ref rightState, ref rightRetractOrigin);
        }
    }

    private void Update()
    {
        GarbageDestroyer();

        if (isHooked)
        {
            UpdateGarbagePosition(hookedGarbage);
        }
    }

    private void UpdateGarbagePosition(GameObject objectToPull)
    {
        Transform clawTransform = transform;
        objectToPull.transform.position = clawTransform.position;
    }

    private void GarbageDestroyer()
    {
        if (GrapplingHookGun.GetLeftState() == GrapplingHook.ClawState.Idle && isHooked)
        {
            Destroy(hookedGarbage);
            isHooked = false;
        }

        if (GrapplingHookGun.GetRightState() == GrapplingHook.ClawState.Idle && isHooked)
        {
            Destroy(hookedGarbage);
            isHooked = false;
        }
    }
}