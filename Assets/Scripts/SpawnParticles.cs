using System.Collections.Generic;
using UnityEngine;

public class SpawnParticles : MonoBehaviour
{
    [SerializeField] private GameObject sandParticlePrefab;
    [SerializeField] private float spawnCooldown = 0.5f;
    private Dictionary<Collider, float> objectCooldowns = new();

    private void Update()
    {
        var keysToRemove = new List<Collider>();

        foreach (var pair in objectCooldowns)
        {
            var newCooldown = pair.Value + Time.deltaTime;
            if (newCooldown >= spawnCooldown)
            {
                keysToRemove.Add(pair.Key);
            }
            else
            {
                objectCooldowns[pair.Key] = newCooldown;
            }
        }

        // Remove any object that has reached the cooldown
        foreach (var key in keysToRemove)
        {
            objectCooldowns.Remove(key);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Claw") || collision.collider.CompareTag("Garbage"))
        {
            SpawnSandParticles(collision.collider);
        }
    }

    private void SpawnSandParticles(Collider collider)
    {
        if (!objectCooldowns.ContainsKey(collider))
        {
            Instantiate(sandParticlePrefab, transform.position, Quaternion.identity);
            objectCooldowns.Add(collider, 0f);
        }
    }
}