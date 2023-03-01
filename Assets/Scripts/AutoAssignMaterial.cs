using UnityEngine;

public class AutoAssignMaterial : MonoBehaviour
{
    [Header("auto assign all children this material")]
    [SerializeField] private Material materialToAssign;
    private void Start()
    {
        Renderer[] renderers = GetComponentsInChildren<Renderer>();
        foreach (Renderer renderer in renderers)
        {
            renderer.material = materialToAssign;
        }
    }
}
