using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterialPortal : MonoBehaviour
{
    [Header("Change children in this object to their original material on portal entry")]
    [SerializeField] private GameObject targetObject;
    [SerializeField] private string collisionWithThisTag = "MainCamera";

    private Vector3 colliderNormal = Vector3.forward;

    private void Update()
    {
        colliderNormal = transform.forward;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag(collisionWithThisTag)) return;
        var direction = other.transform.position - transform.position;
        if (Vector3.Dot(direction.normalized, colliderNormal) > 0)
        {
            // Change the children in the target object back to their original materials
            var autoAssignMaterial = targetObject.GetComponent<AutoAssignMaterial>();
            foreach (KeyValuePair<GameObject, Material> kvp in autoAssignMaterial.oldMaterials)
            {
                kvp.Key.GetComponent<Renderer>().material = kvp.Value;
            }
        }
        else
        {
            // Assign the material in AutoAssigner back
            var autoAssignMaterial = targetObject.GetComponent<AutoAssignMaterial>();
            foreach (Renderer renderer in targetObject.GetComponentsInChildren<Renderer>())
            {
                renderer.material = autoAssignMaterial.materialToAssign;
            }
        }
    }
}