using System.Collections;
using UnityEngine;

public class ObjectRiser : MonoBehaviour
{
    [SerializeField] private float riseSpeed = 1.0f; // The speed at which to rise out of the ground
    [SerializeField] private float checkDistance = 1.0f; // The distance to check for the ground
    [SerializeField] private LayerMask groundLayer; // The layer(s) that represent the ground

    private bool isRising = false; // Whether or not the object is currently rising
    private float floorHeight = 0.0f; // The height of the floor
    private Vector3 targetPosition; // The position to rise to
    private Vector3 initialPosition; // The initial position of the object

    private void Start()
    {
        // Store the initial position of the object
        initialPosition = transform.position;

        // Shoot a raycast down to find the ground
        if (!Physics.Raycast(transform.position, Vector3.down, out var hit, checkDistance, groundLayer)) return;
        floorHeight = hit.point.y;
        targetPosition = new Vector3(initialPosition.x, floorHeight + transform.localScale.y / 2.0f, initialPosition.z);
        StartCoroutine(WaitAndRise());
    }

    private void Update()
    {
        // If the object is rising, move it towards the target position
        if (!isRising) return;
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, riseSpeed * Time.deltaTime);
        if (transform.position == targetPosition)
        {
            isRising = false;
        }
    }

    IEnumerator WaitAndRise()
    {
        yield return new WaitForSeconds(2.0f);
        isRising = true;
    }
}