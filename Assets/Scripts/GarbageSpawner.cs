using System.Linq;
using UnityEngine;

public class GarbageSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] garbagePrefabs;
    [SerializeField] private GameObject player;

    [SerializeField] private float spawnInterval = 3.0f;
    [SerializeField] private float minSpawnHeight = 0.5f;
    [Tooltip("Make sure the grappling distance is able to cover this")]
    [SerializeField] private float maxSpawnHeight = 3f;
    [SerializeField] private float minSpawnDistance = 0.1f;
    [Tooltip("Make sure the grappling distance is able to cover this")]
    [SerializeField] private float maxSpawnDistance = 4f;

    [SerializeField] private int maxGarbageCount = 50;
    [SerializeField] private int minGarbageCount = 20;

    private int currentGarbageCount;

    private int smallGarbageCount;
    private int mediumGarbageCount;
    private int largeGarbageCount;

    private float timeSinceLastSpawn;

    private void Start()
    {
        timeSinceLastSpawn = 0;

        InitialSpawn();
    }

    // Updates on intervals
    private void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;
        if (timeSinceLastSpawn >= spawnInterval && currentGarbageCount < maxGarbageCount)
        {
            timeSinceLastSpawn = 0;
            var spawnPosition = CheckAreaForClearance();

            if (spawnPosition != Vector3.zero)
            {
                SpawnGarbage(spawnPosition);
            }
        }
    }

    private void InitialSpawn()
    {
        var garbageCount = Random.Range(minGarbageCount, maxGarbageCount);
        for (var i = 0; i < garbageCount; i++)
        {
            var spawnPosition = CheckAreaForClearance();
            if (spawnPosition != Vector3.zero)
            {
                SpawnGarbage(spawnPosition);
            }
        }
    }

    // Don't spawn garbage if it's too close to the player or if there's already garbage in the area
    private Vector3 CheckAreaForClearance()
    {
        var spawnPosition = Vector3.zero;
        var attempts = 20;

        while (attempts > 0)
        {
            var randomX = Random.Range(-maxSpawnDistance, maxSpawnDistance);
            var randomZ = Random.Range(-maxSpawnDistance, maxSpawnDistance);
            var randomY = Random.Range(minSpawnHeight, maxSpawnHeight);

            spawnPosition = new Vector3(randomX, randomY, randomZ);

            if (Vector3.Distance(spawnPosition, player.transform.position) < minSpawnDistance)
            {
                attempts--;
                continue;
            }

            Collider[] colliders = Physics.OverlapSphere(spawnPosition, minSpawnDistance);
            var foundGarbage = colliders.Any(collider => collider.CompareTag("Garbage"));

            if (!foundGarbage)
            {
                return spawnPosition;
            }

            attempts--;
        }

        return Vector3.zero;
    }

    // Give the transform of the garbage to the GarbageManager and it's size
    private void SpawnGarbage(Vector3 spawnPosition)
    {
        var garbageIndex = RandomizeGarbage();

        Quaternion randomRotation = Quaternion.Euler(Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360));

        GameObject garbage = Instantiate(garbagePrefabs[garbageIndex], spawnPosition, randomRotation);
        garbage.transform.SetParent(transform);

        switch (garbageIndex)
        {
            case 0:
                smallGarbageCount++;
                break;
            case 1:
                mediumGarbageCount++;
                break;
            case 2:
                largeGarbageCount++;
                break;
        }

        currentGarbageCount++;
    }

    // Put more emphasis of spawning the garbage type that has the least amount
    private int RandomizeGarbage()
    {
        var garbageCounts = new[] { smallGarbageCount, mediumGarbageCount, largeGarbageCount };
        var minValueIndex = 0;

        for (var i = 1; i < garbageCounts.Length; i++)
        {
            if (garbageCounts[i] < garbageCounts[minValueIndex])
            {
                minValueIndex = i;
            }
        }

        var randomValue = Random.value;
        if (randomValue < 0.6f)
        {
            return minValueIndex;
        }
        return Random.Range(0, garbagePrefabs.Length);
    }
}