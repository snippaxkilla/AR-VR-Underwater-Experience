using UnityEngine;

public class AutoAssignMaterial : MonoBehaviour
{
    public Material materialToAssign;

    private void Start()
    {
        AssignMaterialRecursively(transform);
    }

    private void AssignMaterialRecursively(Transform transform)
    {
        foreach (Transform childTransform in transform)
        {
            Renderer renderer = childTransform.GetComponent<Renderer>();

            if (renderer != null)
            {
                renderer.material = materialToAssign;
            }

            if (childTransform.childCount > 0)
            {
                AssignMaterialRecursively(childTransform);
            }
        }
    }
}
