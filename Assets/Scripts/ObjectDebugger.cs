using Oculus.Interaction;
using UnityEngine;

public class ObjectDebugger : MonoBehaviour
{
    [SerializeField] private GameObject objectToPlace;
    private Transform spawnPos;

    // Update is called once per frame
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
