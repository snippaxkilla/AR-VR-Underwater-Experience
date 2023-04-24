using UnityEngine;

public class ObjectLookAt : MonoBehaviour
{
    [SerializeField] private GameObject target;

    private void Start()
    {
        // Set the target's position to be at the same height as the current object
        var targetPosition = target.transform.position;
        targetPosition.y = transform.position.y;

        // Calculate the direction to the target without taking into account the height difference
        var direction = targetPosition - transform.position;
        direction.y = 0;

        // Cast a ray from the object's position to the target's position
        RaycastHit hit;
        if (Physics.Raycast(transform.position, direction, out hit))
        {
            // Get the hit normal and project it onto the XZ plane
            var hitNormal = hit.normal;
            hitNormal.y = 0;

            // Calculate the rotation based on the hit normal
            transform.rotation = Quaternion.LookRotation(hitNormal);
        }
        else
        {
            // If the raycast doesn't hit anything, rotate the object around its y-axis towards the target
            transform.rotation = Quaternion.LookRotation(direction);
        }
    }
}