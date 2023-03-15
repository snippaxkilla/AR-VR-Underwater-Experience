using UnityEngine;

public class ObjectLookAt : MonoBehaviour
{
    [SerializeField] private GameObject target;

    Vector3 targetPosition;

    private void Start()
    {
        targetPosition = target.transform.position;
        targetPosition.y = 0;

        transform.LookAt(targetPosition);
    }
}
