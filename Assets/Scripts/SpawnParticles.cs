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

            // If the cooldown is greater than the set cooldownSpawn, reset it back to cooldownSpawn
            if (clawCooldowns[key] > cooldownSpawn)
            {
                clawCooldowns[key] = cooldownSpawn;
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Collider other = collision.collider;

        if (other.CompareTag("Claw"))
        {
            if (!clawCooldowns.ContainsKey(other) || clawCooldowns[other] >= cooldownSpawn)
            {
                Instantiate(SandParticle, transform.position, Quaternion.identity);
                clawCooldowns[other] = 0f;
            }
        }
    }
}