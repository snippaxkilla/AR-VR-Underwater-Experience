using UnityEngine;

public class Claw : MonoBehaviour
{
    [SerializeField] private GameObject GroupedGarbage;
    [SerializeField] private GameObject Player;
    [SerializeField] private GameObject GrapplingHookGun;

    private bool isHooked;
    private GameObject hookedGarbage;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.transform.parent == GroupedGarbage.transform)
        {
            hookedGarbage = other.gameObject;
            isHooked = true;

            // TODO: create the references for pullback otherwise they can't be called
            //StartPullback(hookedGarbage, clawLeft, ref clawLeftState, ref leftClawRetractOrigin);
            //StartPullback(hookedGarbage, clawRight, ref clawRightState, ref rightClawRetractOrigin);
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

    private void StartPullback(GameObject objectToPull, Rigidbody claw, ref GrapplingHook.ClawState state, ref Vector3 retractOrigin)
    {
        var grapplingHook = GrapplingHookGun.GetComponent<GrapplingHook>();
        Rigidbody clawRigidbody = objectToPull.GetComponent<Rigidbody>();

        grapplingHook.RetractClaw(claw, ref state, ref retractOrigin);
         
        Destroy(objectToPull);
        isHooked = false;
    }
}