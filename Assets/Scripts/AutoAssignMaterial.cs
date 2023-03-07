using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class AutoAssignMaterial : MonoBehaviour
{
    [Header("auto assign all children this material")]
    [SerializeField] public Material materialToAssign;

    // List to store all old materials and their corresponding GameObjects
    public List<KeyValuePair<GameObject, Material>> oldMaterials = new List<KeyValuePair<GameObject, Material>>();

    private void Start()
    {
        Renderer[] renderers = GetComponentsInChildren<Renderer>();
        foreach (Renderer renderer in renderers)
        {
            // Store the old material and corresponding GameObject in the list
            oldMaterials.Add(new KeyValuePair<GameObject, Material>(renderer.gameObject, renderer.material));

            // Assign the new material
            renderer.material = materialToAssign;
        }
    }

    // Example method to retrieve the old material for a specific GameObject
    public Material GetOldMaterial(GameObject go)
    {
        return (from kvp in oldMaterials where kvp.Key == go select kvp.Value).FirstOrDefault();
    }
}