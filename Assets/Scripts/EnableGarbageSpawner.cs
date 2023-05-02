using UnityEngine;

public class EnableGarbageSpawner : MonoBehaviour
{
    [SerializeField] private GarbageSpawner garbageSpawner;
        
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "MainCamera")
        {
            garbageSpawner.SetGarbageSpawnerState(GarbageSpawner.GarbageSpawnerState.On);
        }
    }
}