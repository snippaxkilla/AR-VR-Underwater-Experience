using UnityEngine;

public class FishManager : MonoBehaviour
{
    [SerializeField] private GameObject[] fishPrefabs;

    // On start we want to disable all child objects first
    private void Start()
    {
        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    private void Update()
    {
       
    }

    private void EnableFishOnScore()
    {
        var playerScore = GarbageCollector.Instance.GetGarbageCollectedCount();

    }
}
