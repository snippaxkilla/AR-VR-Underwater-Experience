using UnityEngine;

public class ObjectLookAt : MonoBehaviour
{
    [SerializeField] private Transform _toRotate;
    [SerializeField] private GameObject _target;

    private void Start()
    {
        _target = GameObject.FindGameObjectWithTag("MainCamera");

        Vector3 targetPosition = new Vector3(_target.transform.position.x, _toRotate.position.y, _target.transform.position.z);
        Vector3 dirToTarget = (targetPosition - _toRotate.position).normalized;

        // Create a custom 'up' vector with only the Y component from the original up vector.
        Vector3 customUp = new Vector3(0, _toRotate.up.y, 0);

        Quaternion targetRotation = Quaternion.LookRotation(dirToTarget, customUp);
        _toRotate.rotation = targetRotation;
    }
}