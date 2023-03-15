using UnityEngine;

public class OccludingPlanePlacer : MonoBehaviour
{
    [SerializeField] private GameObject occludingPlane;

    [Header("Object riser reference")]
    [SerializeField] private ObjectRiser objectRiser;

    private GameObject occludingPlaneInstance; // Keep a reference to the instantiated object

    private void Start()
    {
        // Prevent z flicker by placing the plane slightly above the ground
        var spawnPosition = new Vector3(transform.position.x, 0.1f, transform.position.z);
        occludingPlaneInstance = Instantiate(occludingPlane, spawnPosition, Quaternion.identity); // Store reference to instantiated object
    }

    private void Update()
    {
        if (objectRiser.isRising) return;
        // If the object is not rising, destroy the previously instantiated object
        if (occludingPlaneInstance != null)
        {
            // delay in accordance to the particle system duration
            Destroy(occludingPlaneInstance, 5f);
        }
    }
}
