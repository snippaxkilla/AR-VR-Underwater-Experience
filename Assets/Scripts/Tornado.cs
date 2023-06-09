using System.Collections.Generic;
using UnityEngine;

public class Tornado : MonoBehaviour
{
    [Tooltip("Distance after which the rotation physics starts")]
    [SerializeField] private float maxDistance = 20;

    [Tooltip("The axis that the caught objects will rotate around")]
    [SerializeField] private Vector3 rotationAxis = new Vector3(0, 1, 0);

    [Tooltip("Angle that is added to the object's velocity (higher lift -> quicker on top)")]
    [Range(0, 90)]
    [SerializeField]
    public float lift = 45;

    [Tooltip("The force that will drive the caught objects around the tornado's center")]
    [SerializeField] private float rotationStrength = 50;

    [Tooltip("Tornado pull force")]
    [SerializeField] private float tornadoStrength = 2;

    private Rigidbody r;

    private HashSet<Caught> caughtObjects = new HashSet<Caught>();

    private void Start()
    {
        rotationAxis.Normalize();

        r = GetComponent<Rigidbody>();
        r.isKinematic = true;
    }

    private void FixedUpdate()
    {
        // Apply force to caught objects
        foreach (var caughtObject in caughtObjects)
        {
            if (caughtObject != null && caughtObject.enabled)
            {
                Vector3 pull = transform.position - caughtObject.transform.position;
                if (pull.magnitude > maxDistance)
                {
                    caughtObject.rigidBody.AddForce(pull.normalized * pull.magnitude, ForceMode.Force);
                    caughtObject.enabled = false;
                }
                else
                {
                    caughtObject.enabled = true;
                }
            }
        }

        // Cleanup: Remove null or destroyed objects from the list.
        caughtObjects.RemoveWhere(caughtObject => caughtObject == null);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.attachedRigidbody || other.attachedRigidbody.isKinematic) return;

        Caught caught = other.GetComponent<Caught>();
        if (!caught)
        {
            caught = other.gameObject.AddComponent<Caught>();
            caught.Init(this, r, tornadoStrength);
        }

        caughtObjects.Add(caught);
    }

    private void OnTriggerExit(Collider other)
    {
        Caught caught = other.GetComponent<Caught>();
        if (caught)
        {
            caught.Release();
            caughtObjects.Remove(caught);
        }
    }

    public float GetStrength()
    {
        return rotationStrength;
    }

    // The axis the caught objects rotate around
    public Vector3 GetRotationAxis()
    {
        return rotationAxis;
    }

    // Draw tornado radius circle in Editor
    private void OnDrawGizmosSelected()
    {
        Vector3[] positions = new Vector3[30];
        Vector3 centrePos = transform.position;
        for (int pointNum = 0; pointNum < positions.Length; pointNum++)
        {
            var i = (float)(pointNum * 2) / positions.Length;

            var angle = i * Mathf.PI * 2;

            var x = Mathf.Sin(angle) * maxDistance;
            var z = Mathf.Cos(angle) * maxDistance;

            Vector3 pos = new Vector3(x, 0, z) + centrePos;
            positions[pointNum] = pos;
        }

        Gizmos.color = Color.cyan;
        for (int i = 0; i < positions.Length; i++)
        {
            if (i == positions.Length - 1)
            {
                Gizmos.DrawLine(positions[0], positions[positions.Length - 1]);
            }
            else
            {
                Gizmos.DrawLine(positions[i], positions[i + 1]);
            }
        }
    }
}