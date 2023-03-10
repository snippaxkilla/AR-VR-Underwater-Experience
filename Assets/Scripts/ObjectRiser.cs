using UnityEngine;

public class ObjectRiser : MonoBehaviour
{
    [Header("Rise the object")]
    [SerializeField] private float riseSpeed = 1f;
    [SerializeField] private float offset = 0f;

    [Header("Object shaker modifiers")]
    [SerializeField] private bool canShake = false;
    [SerializeField] private float shakeDuration = 5f;
    [SerializeField] private float shakeIntensity = 1f;
    [SerializeField] private float shakeSpeed = 0.2f;

    private Vector3 originalPosition;
    private float maxHeight;
    private float currentHeight;
    private bool isRising = true;

    private void Start()
    {
        // Get the height of the collider and set maxHeight accordingly, with an offset
        maxHeight = GetComponent<Collider>().bounds.size.y + offset;
        currentHeight = 0f;

        // Ignore collisions with all other colliders in the scene
        Collider[] colliders = Physics.OverlapSphere(transform.position, maxHeight);
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
        if (currentHeight < maxHeight)
        {
            currentHeight += riseSpeed * Time.deltaTime;
            currentHeight = Mathf.Clamp(currentHeight, 0f, maxHeight);
            transform.position = new Vector3(transform.position.x, currentHeight, transform.position.z);
        }
        else if (isRising)
        {
            // Enable collisions with all other colliders in the scene
            Collider[] colliders = Physics.OverlapSphere(transform.position, maxHeight);
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