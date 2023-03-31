using UnityEngine;

public class ChangeLayerPortal : MonoBehaviour
{
    [Header("Put in the layer you want to change to in new layer vice versa")]
    [SerializeField] private string newLayerName = "Default";
    [SerializeField] private string oldLayerName = "InsidePortal";

    [Header("Change children in this object to corresponding new layer")]
    [SerializeField] private GameObject targetObject;
    [SerializeField] private string collisionWithThisTag = "MainCamera";

    [Header("Enable one way portal to close off the real world")]
    [SerializeField] private bool oneWayPortal = false;

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

    // Only when entering the portal from the frontal direction we go into the if statement
    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag(collisionWithThisTag)) return;
        var direction = other.transform.position - transform.position;
        if (Vector3.Dot(direction.normalized, colliderNormal) > 0)
        {
            ChangeChildrenLayer(targetObjectTransform, newLayer);
        }
        else
        {
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