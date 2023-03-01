using UnityEngine;

public class ChangeLayerPortal : MonoBehaviour
{
    [Header("Put in the layer you want to change to in new layer vice versa")]
    [SerializeField] private string newLayerName = "default";
    [SerializeField] private string oldLayerName = "insidePortal";
    [Header("Change children in this object to corresponding new layer")]
    [SerializeField] private GameObject targetObject;

    private int newLayer;
    private int oldLayer;
    private Transform targetObjectTransform;
    private Vector3 colliderNormal = Vector3.forward;

    private void Start()
    {
        newLayer = LayerMask.NameToLayer(newLayerName);
        oldLayer = LayerMask.NameToLayer(oldLayerName);
        targetObjectTransform = targetObject.transform;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;
        var direction = other.transform.position - transform.position;
        if (Vector3.Dot(direction.normalized, colliderNormal) > 0)
        {
            ChangeChildrenLayer(targetObjectTransform, newLayer);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (!other.CompareTag("Player")) return;
        var direction = other.transform.position - transform.position;
        if (Vector3.Dot(direction.normalized, colliderNormal) < 0)
        {
            ChangeChildrenLayer(targetObjectTransform, oldLayer);
        }
    }

    private static void ChangeChildrenLayer(Transform parent, int newLayer)
    {
        if (parent.gameObject.layer != newLayer)
        {
            parent.gameObject.layer = newLayer;
        }

        foreach (Transform child in parent)
        {
            ChangeChildrenLayer(child, newLayer);
        }
    }
}