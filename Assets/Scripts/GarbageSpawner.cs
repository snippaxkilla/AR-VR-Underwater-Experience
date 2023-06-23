using System;
using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

public class GarbageSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] garbagePrefabs;
    [SerializeField] private GameObject player;

    [SerializeField] private int totalPoolGarbageCount = 500;

    [Tooltip("Lower the spawnInterval significantly when batchSpawning")]
    [SerializeField] private float spawnInterval = 3.0f;
    [SerializeField] private float minSpawnHeight = 0.1f;

    [Tooltip("Make sure the grappling distance is able to cover this")] 
    [SerializeField] private float maxSpawnHeight = 2f;
    [SerializeField] private float minSpawnDistance = 0.1f;
    [Tooltip("Make sure the grappling distance is able to cover this")] 
    [SerializeField] private float maxSpawnDistance = 4f;

    [SerializeField] private int maxGarbageCount = 50;
    [SerializeField] private int minGarbageCount = 20;

    [SerializeField] private int currentGarbageCount;

    private int smallGarbageCount;
    private int mediumGarbageCount;
    private int largeGarbageCount;

    private float timeSinceLastSpawn;

    private bool hasInitialySpawned = false;

    public enum GarbageSpawnerState
    {
        On,
        Off,
        Pause,
        Resume,
        Batch,
        UnderGround
    }

    // Call from another script to start spawning
    public GarbageSpawnerState garbageSpawnerState;

    private void Update()
    {
        switch (garbageSpawnerState)
        {
            case GarbageSpawnerState.On:
                InitialSpawn();
                break;
            case GarbageSpawnerState.Off:
                HandleOffState();
                break;
            case GarbageSpawnerState.Pause:
                return;
            case GarbageSpawnerState.Resume:
                HandleResumeState();
                break;
            case GarbageSpawnerState.UnderGround:
                DevelopmentalFunction();
                break;
            case GarbageSpawnerState.Batch:
                BatchSpawning();
                break;
        }
    }

    private void HandleResumeState()
    {
        timeSinceLastSpawn += Time.deltaTime;
        if (!(timeSinceLastSpawn >= spawnInterval) || currentGarbageCount >= maxGarbageCount) return;
        var spawnPosition = CheckAreaForClearance();

        if (spawnPosition == Vector3.zero) return;
        SpawnGarbage(spawnPosition);
        timeSinceLastSpawn = 0;
    }

    private void HandleOffState()
    {
        if (totalPoolGarbageCount == 0 && garbageSpawnerState != GarbageSpawnerState.Off)
        {
            garbageSpawnerState = GarbageSpawnerState.Off;
        }
    }

    private void InitialSpawn()
    {
        if (!hasInitialySpawned)
        {
            var garbageCount = Random.Range(minGarbageCount, maxGarbageCount);
            for (var i = 0; i < garbageCount; i++)
            {
                var spawnPosition = CheckAreaForClearance();

                if (spawnPosition != Vector3.zero)
                {
                    SpawnGarbage(spawnPosition);
                    hasInitialySpawned = true;
                }
            }
        }

        garbageSpawnerState = GarbageSpawnerState.Resume;
    }

    // For spawning in through non regular means for example boat dumps a lot of garbage
    private void BatchSpawning()
    {
        var garbageCount = Random.Range(minGarbageCount, maxGarbageCount);
        for (var i = 0; i < garbageCount; i++)
        {
            var spawnPosition = CheckAreaForClearance();

            if (spawnPosition != Vector3.zero)
            {
                SpawnGarbage(spawnPosition);
                garbageSpawnerState = GarbageSpawnerState.Pause;
            }
        }
    }

    // Don't spawn garbage if it's too close to the player or if there's already garbage in the area
    private Vector3 CheckAreaForClearance()
    {
        var spawnPosition = Vector3.zero;
        var layerMask = 1 << LayerMask.NameToLayer("Garbage");

        while (totalPoolGarbageCount > 0)
        {
            var randomX = Random.Range(-maxSpawnDistance, maxSpawnDistance);
            var randomZ = Random.Range(-maxSpawnDistance, maxSpawnDistance);
            var randomY = Random.Range(minSpawnHeight, maxSpawnHeight);

            spawnPosition = new Vector3(randomX, randomY, randomZ);

            if (Vector3.Distance(spawnPosition, player.transform.position) < minSpawnDistance)
            {
                continue;
            }

            var sphereCastOrigin = spawnPosition - new Vector3(0, minSpawnHeight, 0);
            var sphereCastDirection = Vector3.up;

            var foundObstacle = Physics.SphereCast(sphereCastOrigin, minSpawnDistance, sphereCastDirection,
                out RaycastHit hit, minSpawnHeight * 2, layerMask);

            if (!foundObstacle)
            {
                return spawnPosition;
            }

            totalPoolGarbageCount--;
        }

        return Vector3.zero;
    }

    // Give the transform of the garbage to the GarbageManager and it's size
    private void SpawnGarbage(Vector3 spawnPosition)
    {
        var garbageIndex = RandomizeGarbage();

        Quaternion randomRotation = Quaternion.Euler(Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360));

        GameObject garbageObject = Instantiate(garbagePrefabs[garbageIndex], spawnPosition, randomRotation);
        garbageObject.transform.SetParent(transform);

        Garbage garbage = garbageObject.GetComponent<Garbage>();

        switch (garbage.GetSize())
        {
            case Garbage.GarbageSize.Small:
                smallGarbageCount++;
                break;
            case Garbage.GarbageSize.Medium:
                mediumGarbageCount++;
                break;
            case Garbage.GarbageSize.Large:
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

        Garbage.GarbageSize leastGarbageSize = (Garbage.GarbageSize)minValueIndex;

        var randomValue = Random.value;
        if (randomValue < 0.6f)
        {
            return Array.FindIndex(garbagePrefabs, g => g.GetComponent<Garbage>().GetSize() == leastGarbageSize);
        }

        return Random.Range(0, garbagePrefabs.Length);
    }

    public void GarbageDestroyed(Garbage garbage)
    {
        Garbage.GarbageSize garbageSize = garbage.GetSize();

        switch (garbageSize)
        {
            case Garbage.GarbageSize.Small:
                smallGarbageCount--;
                break;
            case Garbage.GarbageSize.Medium:
                mediumGarbageCount--;
                break;
            case Garbage.GarbageSize.Large:
                largeGarbageCount--;
                break;
        }

        currentGarbageCount--;
    }

    private void DevelopmentalFunction()
    {
        if(hasInitialySpawned) return;
        StartCoroutine(DelaySpawn());
    }

    private IEnumerator DelaySpawn()
    {
        yield return new WaitForSeconds(5);
        garbageSpawnerState = GarbageSpawnerState.On;
    }

    public GarbageSpawnerState GetGarbageSpawnerState()
    {
        return garbageSpawnerState;
    }

    public void SetGarbageSpawnerState(GarbageSpawnerState newState)
    {
        garbageSpawnerState = newState;
    }
}