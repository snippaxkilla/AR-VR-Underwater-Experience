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

        // Rotate the object around its y-axis towards the target
        transform.rotation = Quaternion.LookRotation(direction);
    }
}