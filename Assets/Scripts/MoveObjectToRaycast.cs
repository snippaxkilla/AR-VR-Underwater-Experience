using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class MoveObjectToRaycast : MonoBehaviour
{
    [SerializeField] private GameObject objectToMove;
    [SerializeField] private GameObject previewObject;
    [SerializeField] private float checkRadius = 0.1f;
    [SerializeField] private LayerMask sceneLayer;
    [SerializeField] private Color canSpawnColor = Color.green;
    [SerializeField] private Color cannotSpawnColor = Color.red;
    [SerializeField] private OVRInput.RawButton placeObjectButton;

    private LineRenderer lineRenderer;
    private Dictionary<OVRInput.Controller, GameObject> previews = new Dictionary<OVRInput.Controller, GameObject>();

    private void Awake()
    {
        objectToMove.SetActive(false);
        foreach (var controller in new OVRInput.Controller[] { OVRInput.Controller.RTouch, OVRInput.Controller.LTouch })
        {
            GameObject controllerPreview = Instantiate(previewObject);
            controllerPreview.SetActive(false);
            previews[controller] = controllerPreview;
        }
    }

    private void Start()
    {
        lineRenderer = gameObject.AddComponent<LineRenderer>();
        lineRenderer.startWidth = 0.01f;
        lineRenderer.endWidth = 0.01f;
        lineRenderer.material = new Material(Shader.Find("Unlit/Color"));
    }

    private void Update()
    {
        foreach (OVRInput.Controller controller in new OVRInput.Controller[] { OVRInput.Controller.RTouch, OVRInput.Controller.LTouch })
        {
            Vector3 controllerPosition = OVRInput.GetLocalControllerPosition(controller);
            Quaternion controllerRotation = OVRInput.GetLocalControllerRotation(controller);

            Ray controllerRay = new Ray(controllerPosition, controllerRotation * Vector3.forward);
            RaycastHit hit;

            lineRenderer.SetPosition(0, controllerRay.origin);

            if (Physics.Raycast(controllerRay, out hit, 1000.0f, sceneLayer))
            {
                lineRenderer.SetPosition(1, hit.point);

                float iconHeight = Mathf.Abs(Vector3.Dot(Vector3.up, hit.normal)) < 0.5f ? 0 : hit.point.y;
                if (iconHeight != 0)
                {
                    Collider[] overlapColliders = Physics.OverlapSphere(hit.point, checkRadius);
                    if (overlapColliders.Length == 0)
                    {
                        if (OVRInput.Get(placeObjectButton, controller))
                        {
                            previews[controller].transform.position = hit.point;
                            previews[controller].SetActive(true);
                            lineRenderer.material.color = canSpawnColor;
                        }
                        else
                        {
                            lineRenderer.material.color = cannotSpawnColor;
                        }

                        if (OVRInput.GetUp(placeObjectButton, controller))
                        {
                            objectToMove.transform.position = hit.point;
                            objectToMove.SetActive(true);
                            previews.Values.ToList().ForEach(preview => preview.SetActive(false));
                        }
                    }
                    else
                    {
                        previews[controller].SetActive(false);
                        lineRenderer.material.color = cannotSpawnColor;
                    }
                }
                else
                {
                    lineRenderer.SetPosition(1, controllerRay.origin + controllerRay.direction * 100);
                    previews[controller].SetActive(false);
                    lineRenderer.material.color = cannotSpawnColor;
                }
            }
            else
            {
                lineRenderer.SetPosition(1, controllerRay.origin + controllerRay.direction * 100);
                previews[controller].SetActive(false);
                lineRenderer.material.color = cannotSpawnColor;
            }
        }
    }
}
