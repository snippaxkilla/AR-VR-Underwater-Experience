using UnityEngine;

public class OffLimit : MonoBehaviour
{
    [SerializeField] private GrapplingHook grapplingHook;
    [SerializeField] private GarbageSpawner garbageSpawner;

    private void Start()
    {
        SphereCollider sc = gameObject.GetComponent<SphereCollider>();
        if (sc == null)
        {
            sc = gameObject.AddComponent<SphereCollider>();
        }

        sc.isTrigger = true;
        sc.radius = grapplingHook.GetMaxDistance();
        sc.radius *= 0.8f;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Garbage"))
        {
            UpdateGarbageCount(other.gameObject);
            Destroy(other.gameObject);
        }
    }

    private void UpdateGarbageCount(GameObject garbageObject)
    {
        Garbage garbage = garbageObject.GetComponent<Garbage>();
        garbageSpawner.GarbageDestroyed(garbage);
    }
}