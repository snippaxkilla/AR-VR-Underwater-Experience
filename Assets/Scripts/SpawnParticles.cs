using System.Collections.Generic;
using UnityEngine;

public class SpawnParticles : MonoBehaviour
{
    [SerializeField] private GameObject SandParticle;

    private float cooldownSpawn = 0.5f;

    private Dictionary<Collider, float> clawCooldowns = new Dictionary<Collider, float>();

    private void Update()
    {
        List<Collider> keys = new List<Collider>(clawCooldowns.Keys);
        foreach (Collider key in keys)
        {
            clawCooldowns[key] += Time.deltaTime;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Collider other = collision.collider;

        if (other.CompareTag("Claw"))
        {
            if (!clawCooldowns.ContainsKey(other))
            {
                clawCooldowns.Add(other, cooldownSpawn);
            }

            if (clawCooldowns[other] >= cooldownSpawn)
            {
                Instantiate(SandParticle, transform.position, Quaternion.identity);
                clawCooldowns[other] = 0f;
            }
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        Collider other = collision.collider;

        if (other.CompareTag("Claw") && clawCooldowns.ContainsKey(other))
        {
            clawCooldowns.Remove(other);
        }
    }
}