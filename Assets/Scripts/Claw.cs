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

    // Retract the hook earlier because the claw hit an object and we want to pull it back
    private void StartPullback(GameObject objectToPull)
    {
        var grapplingHook = GrapplingHook.GetComponent<GrapplingHook>();
        grapplingHook.RetractHook(gameObject, transform.position);

        // Pull the object back to the player first before destroying it
        Destroy(objectToPull);
    }
}