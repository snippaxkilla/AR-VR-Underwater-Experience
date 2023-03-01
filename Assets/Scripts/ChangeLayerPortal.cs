using UnityEngine;

public class ChangeLayerPortal : MonoBehaviour
{
    [Header("Put in the layer you want to change to in new layer vice versa")]
    [SerializeField] private string newLayerName = "default";
    [SerializeField] private string oldLayerName = "insidePortal";
    [Header("Change children in this object to corresponding new layer")]
    [SerializeField] private GameObject targetObject;

    private Vector3 colliderNormal = Vector3.forward; // The normal direction of the collider surface
    private int newLayer; 
    private int oldLayer; 

    private void Start()
    {
        newLayer = LayerMask.NameToLayer(newLayerName);
        oldLayer = LayerMask.NameToLayer(oldLayerName);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.gameObject.CompareTag("Player")) return;
        var direction = other.transform.position - transform.position;
        if (Vector3.Dot(direction.normalized, colliderNormal) > 0)
        {
            ChangeChildrenLayer(targetObject.transform, newLayer);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (!other.gameObject.CompareTag("Player")) return;
        var direction = other.transform.position - transform.position;
        if (Vector3.Dot(direction.normalized, colliderNormal) < 0)
        {
            ChangeChildrenLayer(targetObject.transform, oldLayer);
        }
    }

    private static void ChangeChildrenLayer(Transform parent, int newLayer)
    {
        parent.gameObject.layer = newLayer;
        foreach (Transform child in parent)
        {
            ChangeChildrenLayer(child, newLayer);
        }
    }
}