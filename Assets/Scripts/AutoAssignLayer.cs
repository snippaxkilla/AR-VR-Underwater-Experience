using UnityEngine;

public class AutoAssignLayer : MonoBehaviour
{
    [Header("auto assign all children this layer")]
    [SerializeField] private string layerName = "InsidePortal";

    private void Start()
    {
        var layer = LayerMask.NameToLayer(layerName);

        foreach (Transform child in transform)
        {
            child.gameObject.layer = layer;
        }
    }
}

