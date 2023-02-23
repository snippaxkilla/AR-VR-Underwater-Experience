using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class RaycastPlaceObject : MonoBehaviour
{
    // standard offset is set on 0 but set the Y on a certain value to make the object hover above the ground
    // but we set it on 0.01f to avoid the object to be clipped in the ground
    [SerializeField] private bool rayVisible = true;
    [SerializeField] private int maxObjects = 1;
    [SerializeField] private Vector3 offset;
    [SerializeField] private OVRInput.RawButton[] leftButtons;
    [SerializeField] private OVRInput.RawButton[] rightButtons;

    public GameObject objectToPlace;
    public Transform _targetingIconLeft;
    public Transform _targetingIconRight;
    public LineRenderer _raycastLineLeft;
    public LineRenderer _raycastLineRight;
    public LayerMask _sceneLayer;

    Queue<GameObject> placedObjects = new();

    void Update()
    {
        OffsetCalculation();
        UpdateRaycastLine();
        var resultLeft = Raycast(OVRInput.Controller.LTouch, leftButtons);
        var resultRight = Raycast(OVRInput.Controller.RTouch, rightButtons);
        _targetingIconLeft.position = resultLeft.position;
        _targetingIconRight.position = resultRight.position;
        _targetingIconLeft.localScale = resultLeft.scale;
        _targetingIconRight.localScale = resultRight.scale;
        //EditorTester();
    }

    void OffsetCalculation()
    {
        if (offset == Vector3.zero)
        {
            return;
        }
        var objectPos = objectToPlace.transform.position;
        objectPos += offset;
        objectToPlace.transform.position = objectPos;
    }

    // does the exact same as the raycast function, but it is to test it out on the computer
    //void EditorTester()
    //{
    //    if (Input.GetMouseButtonDown(0))
    //    {
    //        placedObjects.Enqueue(Instantiate(objectToPlace, _targetingIcon.position, Quaternion.identity));
    //        if (maxObjects > 0 && placedObjects.Count > maxObjects)
    //        {
    //            Destroy(placedObjects.Dequeue());
    //        }
    //    }
    //}

    RaycastResult Raycast(OVRInput.Controller controller, OVRInput.RawButton[] buttons)
    {
        var returnValue = new RaycastResult();
        Vector3 rayPos = OVRInput.GetLocalControllerPosition(controller);
        Vector3 rayFwd = OVRInput.GetLocalControllerRotation(controller) * Vector3.forward;
        if (Physics.Raycast(rayPos, rayFwd, out var hitInfo, 1000.0f, _sceneLayer))
        {
            // if hitting a vertical surface, drop quad to the floor
            float iconHeight = Mathf.Abs(Vector3.Dot(Vector3.up, hitInfo.normal)) < 0.5f ? 0 : hitInfo.point.y;
            // offset quad a bit so it doesn't z-flicker
            returnValue.position = new Vector3(hitInfo.point.x, iconHeight + 0.01f, hitInfo.point.z);
        }
        bool pressingButton = buttons.Any(b => OVRInput.Get(b, controller));
        Vector3 position = hitInfo.point + offset;
        if (pressingButton)
        {
            placedObjects.Enqueue(Instantiate(objectToPlace, position, Quaternion.identity));
            if (maxObjects > 0 && placedObjects.Count > maxObjects)
            {
                Destroy(placedObjects.Dequeue());
            }
            returnValue.scale = Vector3.one * 0.6f;
        }
        return returnValue;
    }

    void UpdateRaycastLine()
    {
        _raycastLineLeft.SetPosition(0, OVRInput.GetLocalControllerPosition(OVRInput.Controller.LTouch));
        _raycastLineRight.SetPosition(0, OVRInput.GetLocalControllerPosition(OVRInput.Controller.RTouch));
        _raycastLineLeft.SetPosition(1, _targetingIconLeft.position);
        _raycastLineRight.SetPosition(1, _targetingIconRight.position);
    }
    
    void ToggleRayVisibility()
    {
        rayVisible = !rayVisible;
        _raycastLineLeft.enabled = rayVisible;
        _raycastLineRight.enabled = rayVisible;
    }

    struct RaycastResult
    {
        public Vector3 position;
        public Vector3 scale;
    }
}




