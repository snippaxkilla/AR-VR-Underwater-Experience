using UnityEngine;

public class Claw : MonoBehaviour
{
    [SerializeField] private GameObject GroupedGarbage;
    [SerializeField] private GameObject Player;
    [SerializeField] private GameObject GrapplingHook;

    private bool isHooked;
    private GameObject hookedGarbage;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.transform.parent == GroupedGarbage.transform)
        {
            hookedGarbage = other.gameObject;
            isHooked = true;
            StartPullback(hookedGarbage);
        }
    }

    private void Update()
    {
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

    private void StartPullback(GameObject objectToPull)
    {
        var grapplingHook = GrapplingHook.GetComponent<GrapplingHook>();
        Rigidbody clawRigidbody = objectToPull.GetComponent<Rigidbody>();

        if (grapplingHook.clawLeft)
        {
            grapplingHook.RetractClaw(clawRigidbody, ref grapplingHook.clawLeftState, ref grapplingHook.leftClawRetractOrigin);
            if (grapplingHook.clawLeftState == global::GrapplingHook.ClawState.Idle)
            {
                Destroy(objectToPull);
                isHooked = false;
            }
        }

        if (grapplingHook.clawRight)
        {
            grapplingHook.RetractClaw(clawRigidbody, ref grapplingHook.clawRightState, ref grapplingHook.rightClawRetractOrigin);
            if (grapplingHook.clawRightState == global::GrapplingHook.ClawState.Idle)
            {
                Destroy(objectToPull);
                isHooked = false;
            }
        }
    }
}