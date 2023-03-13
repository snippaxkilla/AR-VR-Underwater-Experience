using UnityEngine;

public class ObjectRiser : MonoBehaviour
{
    [Header("Rise the object")]
    [SerializeField] private float riseSpeed = 1f;
    [SerializeField] private float offset = 0f;
    [SerializeField] private float currentHeight;

    [Header("Object shaker modifiers")]
    [SerializeField] private bool canShake = false;
    [SerializeField] private float shakeIntensity = 1f;
    [SerializeField] private float shakeSpeed = 0.2f;

    private Vector3 originalPosition;
    private float objectHeight;
    private bool isRising = true;

    private void Start()
    {
        // Get the height of the collider and set objectHeight accordingly, with an offset
        objectHeight = GetComponent<Collider>().bounds.size.y + offset;
        currentHeight -= objectHeight;

        // Ignore collisions with all other colliders in the scene
        Collider[] colliders = Physics.OverlapSphere(transform.position, objectHeight);
        foreach (Collider collider in colliders)
        {
            if (collider != GetComponent<Collider>())
            {
                Physics.IgnoreCollision(GetComponent<Collider>(), collider, true);
            }
        }
    }

    private void Update()
    {
        ObjectMaxRiser();
        if (canShake) ObjectShaker();
    }

    private void ObjectMaxRiser()
    {
        if (currentHeight < 0)
        {
            currentHeight += riseSpeed * Time.deltaTime;
            currentHeight = Mathf.Clamp(currentHeight, currentHeight, 0);
            transform.position = new Vector3(transform.position.x, currentHeight, transform.position.z);
        }
        else if (isRising)
        {
            // Enable collisions with all other colliders in the scene
            Collider[] colliders = Physics.OverlapSphere(transform.position, objectHeight);
            foreach (Collider collider in colliders)
            {
                if (collider != GetComponent<Collider>())
                {
                    Physics.IgnoreCollision(GetComponent<Collider>(), collider, false);
                }
            }
            isRising = false;
        }
    }

    private void ObjectShaker()
    {
        if (isRising)
        {
            // Generate a random Perlin noise value based on the current time and speed
            var noiseValue = Mathf.PerlinNoise(0f, Time.time * shakeSpeed);
            // Map the noise value to a shake offset
            var shakeOffset = Vector3.one * Mathf.Lerp(-1f, 1f, noiseValue) * shakeIntensity;
            transform.localPosition = originalPosition + shakeOffset;
        }
        else
        {
            // Reset the object's local position
            transform.localPosition = originalPosition;
        }
    }
}