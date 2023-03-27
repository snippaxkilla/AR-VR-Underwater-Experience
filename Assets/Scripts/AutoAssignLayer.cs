using UnityEngine;

public class AutoAssignLayer : MonoBehaviour
{
    [Header("auto assign all children this layer")]
    [SerializeField] private string layerName = "InsidePortal";

    // Use this to change the layer of all the children of the game object for easier development
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