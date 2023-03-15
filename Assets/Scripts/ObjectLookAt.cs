using UnityEngine;

public class ObjectLookAt : MonoBehaviour
{
    [SerializeField] private GameObject target;

    private void Awake()
    {
        transform.LookAt(target.transform);
    }
}
