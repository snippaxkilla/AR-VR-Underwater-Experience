using UnityEngine;

public class ChangeLayerPortal : MonoBehaviour
{
    [Header("Put in the layer you want to change to in new layer vice versa")]
    [SerializeField] private string newLayerName = "Default";
    [SerializeField] private string oldLayerName = "InsidePortal";

    [Header("Change children in this object to corresponding new layer")]
    [SerializeField] private GameObject targetObject;
    [SerializeField] private string collisionWithThisTag = "MainCamera";

    private PortalManager portalManager;

    private int newLayer;
    private int oldLayer;

    private Transform targetObjectTransform;
    private Vector3 colliderNormal = Vector3.forward;

    private void Start()
    {
        portalManager = GetComponent<PortalManager>();

        newLayer = LayerMask.NameToLayer(newLayerName);
        oldLayer = LayerMask.NameToLayer(oldLayerName);
        targetObjectTransform = targetObject.transform;
    }

    // Only when entering the portal from the frontal direction we go into the if statement
    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag(collisionWithThisTag)) return;

        var direction = other.transform.position - transform.position;
        int newLayerToSet;

        switch (portalManager.portalType)
        {
            // If the portal type is OneWay, set the new layer to default so we see the other world
            case PortalManager.PortalType.OneWay:
                newLayerToSet = newLayer;
                ChangeChildrenLayer(targetObjectTransform, newLayerToSet);
                portalManager.ClosePortalAndOtherWorld();
                break;

            // If the portal type is TwoWay, set the new layer to newLayer if the direction is the same as the normal of the portal
            case PortalManager.PortalType.TwoWay:
            {
                if (Vector3.Dot(direction.normalized, colliderNormal) > 0)
                {
                    newLayerToSet = newLayer;
                }
                else
                {
                    newLayerToSet = oldLayer;
                }
                ChangeChildrenLayer(targetObjectTransform, newLayerToSet);
                break;
            }
        }
    }

    // Change all children in the target object to the new layer
    private static void ChangeChildrenLayer(Transform parent, int newLayer)
    {
        parent.gameObject.layer = newLayer;
        foreach (Transform child in parent)
        {
            ChangeChildrenLayer(child, newLayer);
        }
    }
}