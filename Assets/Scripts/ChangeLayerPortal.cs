using UnityEngine;

public class ChangeLayerPortal : MonoBehaviour
{
    [Header("Put in the layer you want to change to in new layer vice versa")]
    [SerializeField] private string newLayerName = "Default";
    [SerializeField] private string oldLayerName = "InsidePortal";
    [Header("Change children in this object to corresponding new layer")]
    [SerializeField] private GameObject targetObject;
    [SerializeField] private string collisionWithThisTag = "MainCamera";

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
        if (!other.CompareTag(collisionWithThisTag)) return;
        var direction = other.transform.position - transform.position;
        if (Vector3.Dot(direction.normalized, colliderNormal) > 0)
        {
            Debug.Log("Enter");
            ChangeChildrenLayer(targetObjectTransform, newLayer);
        }
        else
        {
            Debug.Log("Exit");
            ChangeChildrenLayer(targetObjectTransform, oldLayer);
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