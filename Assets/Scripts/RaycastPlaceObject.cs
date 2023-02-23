using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class RaycastPlaceObject : MonoBehaviour
{
    // standard offset is set on 0 but set the Y on a certain value to make the object hover above the ground
    [SerializeField] private int rayLength = 10;
    [SerializeField] private int rayThickness = 1;
    [SerializeField] private bool rayVisible = true;
    [SerializeField] private int maxObjects = 1;
    [SerializeField] private float offsetX;
    [SerializeField] private float offsetY;
    [SerializeField] private float offsetZ;

    public GameObject objectToPlace;
    public GameObject clone;
    public Transform _targetingIcon;
    public LineRenderer _raycastLine;
    public LayerMask _sceneLayer;
    private List<GameObject> placedObjects;
    public int indexHelper = 0;

    void Start()
    {
        _raycastLine.enabled = false;
        placedObjects = new List<GameObject>();
    }
    
    void Update()
    {
        OffsetCalculation();
        Raycast();
        //EditorTester();
    }

    void OffsetCalculation()
    {
        if ((offsetX == 0) && (offsetY == 0) && (offsetZ == 0))
        {
            return;
        }
        else
        {
            Vector3 objectPos = objectToPlace.transform.position;
            offsetX += objectPos.x; offsetY += objectPos.y; offsetZ += objectPos.z;
        }
    }

    void EditorTester()
    {
        if (Input.GetMouseButtonDown(0) && indexHelper < maxObjects)
        {
            placedObjects.Add(Instantiate(objectToPlace, _targetingIcon.position, Quaternion.identity));
            indexHelper++;
            Debug.Log(indexHelper);
        }
        if (Input.GetMouseButtonDown(0) && indexHelper >= maxObjects)
        {
            Destroy(placedObjects[indexHelper -1]);
            indexHelper++;
            placedObjects.Add(Instantiate(objectToPlace, _targetingIcon.position, Quaternion.identity));
            Debug.Log(indexHelper);

        }
    }

    void Raycast()
    {
        RaycastHit hitInfo;
        Vector3 rayPos = OVRInput.GetLocalControllerPosition(OVRInput.Controller.RTouch);
        Vector3 rayFwd = OVRInput.GetLocalControllerRotation(OVRInput.Controller.RTouch) * Vector3.forward;
        if (Physics.Raycast(rayPos, rayFwd, out hitInfo, 1000.0f, _sceneLayer))
        {
            // if hitting a vertical surface, drop quad to the floor
            float iconHeight = Mathf.Abs(Vector3.Dot(Vector3.up, hitInfo.normal)) < 0.5f ? 0 : hitInfo.point.y;
            // offset quad a bit so it doesn't z-flicker
            _targetingIcon.position = new Vector3(hitInfo.point.x, iconHeight + 0.01f, hitInfo.point.z);
        }
        bool pressingButton = OVRInput.Get(OVRInput.RawButton.RIndexTrigger) || OVRInput.Get(OVRInput.RawButton.A);
        Vector3 position = hitInfo.point + new Vector3(offsetX, offsetY, offsetZ);
        if (pressingButton && indexHelper < maxObjects)
        {
            placedObjects.Add(Instantiate(objectToPlace, _targetingIcon.position, Quaternion.identity));
            indexHelper++;
        }
        if (pressingButton && indexHelper >= maxObjects)
        {
            Destroy(placedObjects[indexHelper - 1]);
            indexHelper++;
            placedObjects.Add(Instantiate(objectToPlace, _targetingIcon.position, Quaternion.identity));
        }
        _targetingIcon.localScale = Vector3.one * (pressingButton ? 0.6f : 0.5f);
    }

    void UpdateRaycastLine(Vector3 origin, Vector3 direction)
    {
        if (rayVisible)
        {
            _raycastLine.enabled = true;
            _raycastLine.SetPosition(0, origin);
            _raycastLine.SetPosition(1, origin + direction * rayLength);
        }
        else
        {
            _raycastLine.enabled = false;
        }
    }
    
    // debug function not used anywhere now
    void ToggleRayVisibility()
    {
        rayVisible = !rayVisible;
        UpdateRaycastLine(Vector3.zero, Vector3.zero);
    }
}




