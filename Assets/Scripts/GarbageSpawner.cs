using UnityEngine;

public class GarbageSpawner : MonoBehaviour
{
    public GameObject[] garbagePrefabs;

    public float spawnInterval = 3.0f;
    public float minSpawnHeight = 0.5f;
    public float maxSpawnHeight = 5f;

    private float minSpawnDistance = 1f;
    private float maxSpawnDistance = 10f;

    private int maxGarbageCount = 100;
    private int minGarbageCount = 20;
    private int currentGarbageCount;

    private int smallGarbageCount;
    private int mediumGarbageCount;
    private int largeGarbageCount;

    private void Start()
    {

    }

    private void Update()
    {

    }

    // Don't spawn garbage on the player or where there is already garbage
    private void CheckAreaForClearance()
    {

    }

    private void SpawnGarbage()
    {

    }

    // Returns what garbage to spawn based on the current amount of garbage also takes in consideration the garbage size
    private void RandomizeGarbage()
    {
        // Put more emphasis of spawning the garbage type that has the least amount
    }
}
