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
        objectToPull.transform.rotation = clawTransform.rotation;
    }

    private void StartPullback(GameObject objectToPull)
    {
        var grapplingHook = GrapplingHook.GetComponent<GrapplingHook>();
        Rigidbody clawRigidbody = objectToPull.GetComponent<Rigidbody>();

        if (objectToPull.transform == grapplingHook.clawLeft.transform)
        {
            grapplingHook.RetractClaw(clawRigidbody, ref grapplingHook.clawLeftState, ref grapplingHook.leftClawRetractOrigin);
        }

        if (objectToPull.transform == grapplingHook.clawRight.transform)
        {
            grapplingHook.RetractClaw(clawRigidbody, ref grapplingHook.clawRightState, ref grapplingHook.rightClawRetractOrigin);
        }

        // Pull the object back to the player first before destroying it
        Destroy(objectToPull, 5f);
        isHooked = false;
    }
}