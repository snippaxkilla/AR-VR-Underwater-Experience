using UnityEngine;

public class ObjectDebugger : MonoBehaviour
{
    [SerializeField] private GameObject objectToPlace;
    private Transform spawnPos;

    private void Update()
    {
        SpawnObject();
    }

    private void SpawnObject()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(objectToPlace, spawnPos);
        }
    }
}
