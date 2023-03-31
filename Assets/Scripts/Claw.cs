using UnityEngine;

public class Claw : MonoBehaviour
{
    [SerializeField] private GameObject GroupedGarbage;
    [SerializeField] private GameObject Player;
    [SerializeField] private GameObject GrapplingHook;

    private bool isHooked = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.transform.parent == GroupedGarbage.transform)
        {
            StartPullback(other.gameObject);
        }
    }

    private void StartPullback(GameObject objectToPull)
    {
        // Retrieve the GrapplingHook component and retract the hook
        var grapplingHook = GrapplingHook.GetComponent<GrapplingHook>();
        grapplingHook.RetractHook(gameObject, transform.position);

        Destroy(objectToPull);
    }
}