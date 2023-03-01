using UnityEngine;

public class AutoAssignLayer : MonoBehaviour
{
    [Header("auto assign all children this layer")]
    [SerializeField] private string layerName = "InsidePortal";

    private void Start()
    {
        var layer = LayerMask.NameToLayer(layerName);

        Transform[] children = GetComponentsInChildren<Transform>();
        foreach (Transform child in children)
        {
            child.gameObject.layer = layer;
        }
    }
}