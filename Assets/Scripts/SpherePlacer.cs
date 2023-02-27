using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;

public class SpherePlacer : MonoBehaviour
{
    [SerializeField] private float spacing = 5f;
    [SerializeField] private Material sphereMaterial;
    [SerializeField] private GameObject modelObject;
    
    private void Start()
    {
        float modelSize = CalculateModelSize();
        CreateSphere(modelSize);
    }

    private float CalculateModelSize()
    {
        Bounds bounds = new Bounds();
        Renderer[] renderers = modelObject.GetComponentsInChildren<Renderer>();

        foreach (Renderer renderer in renderers)
        {
            bounds.Encapsulate(renderer.bounds);
        }

        return bounds.size.magnitude;
    }

    private void CreateSphere(float radius)
    {
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.transform.localScale = new Vector3(radius, radius, radius);
        float yPos = Mathf.Max(modelObject.transform.position.y + radius + spacing, 0f); // make sure sphere is not below the ground
        sphere.transform.position = modelObject.transform.position + Vector3.up * (radius + spacing);
        sphere.GetComponent<Renderer>().material = sphereMaterial;
    }
}
