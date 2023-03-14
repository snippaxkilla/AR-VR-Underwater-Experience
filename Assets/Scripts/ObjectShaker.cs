using UnityEngine;

public class ObjectShaker : MonoBehaviour
{
    [Header("Object shaker modifiers")]
    [SerializeField] private bool canShake = false;
    [SerializeField] private float shakeIntensity = 0.025f;
    [SerializeField] private float shakeSpeed = 5f;

    [Header("Object riser reference")]
    [SerializeField] private ObjectRiser objectRiser;

    private Vector3 originalPosition;

    private void Start()
    {
        originalPosition = transform.localPosition;
    }

    private void Update()
    {
        if (objectRiser.isRising)
        {
            // Generate a random Perlin noise value based on the current time and speed
            var noiseValue = Mathf.PerlinNoise(0f, Time.time * shakeSpeed);
            // Map the noise value to a shake offset
            var shakeOffset = Mathf.Lerp(-1f, 1f, noiseValue) * shakeIntensity * Vector3.one;
            transform.localPosition = originalPosition + shakeOffset;
        }
        else
        {
            // Reset the object's local position
            transform.localPosition = Vector3.Lerp(transform.localPosition, originalPosition, Time.deltaTime * 10f);
        }
    }
}