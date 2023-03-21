using UnityEngine;

public class OccludingPlanePlacer : MonoBehaviour
{
    [SerializeField] private GameObject occludingPlane;

    [Header("Object riser reference")]
    [SerializeField] private ObjectRiser objectRiser;

    private GameObject occludingPlaneInstance;

    private void Start()
    {
        // Prevent z flicker by placing the plane slightly below the ground
        var spawnPosition = new Vector3(transform.position.x, -0.1f, transform.position.z);
        occludingPlaneInstance = Instantiate(occludingPlane, spawnPosition, Quaternion.identity);
    }

    private void Update()
    {
        DestroySmokeEarly();
        if (objectRiser.isRising) return;
        // If the object is not rising, destroy the previously instantiated object
        if (occludingPlaneInstance != null)
        {
            // Delay in accordance to the particle system duration
            Destroy(occludingPlaneInstance, 5f);
        }
    }

    private void DestroySmokeEarly()
    {
        // Only destroy when a new object is spawned since the Oculus can't handle all the particles
        if (occludingPlaneInstance == null) return;
        for (var i = 0; i < occludingPlaneInstance.transform.childCount; i++)
        {
            Destroy(occludingPlaneInstance.transform.GetChild(i).gameObject);
        }
    }
}
