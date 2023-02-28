using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class RaycastPlaceObject : MonoBehaviour
{
    // standard offset is set on 0 but set the Y on a certain value to make the object hover above the ground
    // but we set it on 0.01f to avoid the object to be clipped in the ground
    [SerializeField] private bool rayVisible = true;
    [SerializeField] private bool isAnchored = false;
    [SerializeField] private int maxObjects = 1;
    [SerializeField] private Vector3 offset;
    [SerializeField] private OVRInput.RawButton[] leftButtons;
    [SerializeField] private OVRInput.RawButton[] rightButtons;

    // keep these items as public to assign them in the inspector
    public GameObject objectToPlace;
    public Transform targetingIconLeft;
    public Transform targetingIconRight;
    public LineRenderer raycastLineLeft;
    public LineRenderer raycastLineRight;
    public LayerMask sceneLayer;

    Queue<GameObject> placedObjects = new();

    void Start()
    {
        ToggleRayVisibility();
    }

    void Update()
    {
        OffsetCalculation();
        UpdateRaycastLine();
        var resultLeft = Raycast(OVRInput.Controller.LTouch, leftButtons, targetingIconLeft);
        var resultRight = Raycast(OVRInput.Controller.RTouch, rightButtons, targetingIconRight);
    }

    // if there is no offset then we don't want to calculate the offset thus saving performance
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


    // cast a ray and give the positions to instantiate a defined object
    RaycastResult Raycast(OVRInput.Controller controller, OVRInput.RawButton[] buttons, Transform targetIcon)
    {
        var returnValue = new RaycastResult();
        var rayPos = OVRInput.GetLocalControllerPosition(controller);
        var rayFwd = OVRInput.GetLocalControllerRotation(controller) * Vector3.forward;
        if (Physics.Raycast(rayPos, rayFwd, out var hitInfo, 1000.0f, sceneLayer))
        {
            // if hitting a vertical surface, drop quad to the floor
            var iconHeight = Mathf.Abs(Vector3.Dot(Vector3.up, hitInfo.normal)) < 0.5f ? 0 : hitInfo.point.y;
            // offset quad a bit so it doesn't z-flicker
            targetIcon.position = new Vector3(hitInfo.point.x, iconHeight + 0.01f, hitInfo.point.z);
        }
        var pressingButton = buttons.Any(button => OVRInput.GetDown(button, controller));
        var position = hitInfo.point + offset;
        if (!pressingButton) return returnValue;

        // anchor all the objects so we don't spawn any new objects, thus not being able to move the objects
        if (isAnchored && maxObjects == placedObjects.Count)
        {
            return returnValue;
        }
        placedObjects.Enqueue(Instantiate(objectToPlace, position, Quaternion.identity));
        if (maxObjects > 0 && placedObjects.Count > maxObjects)
        {
            Destroy(placedObjects.Dequeue());
        }
        targetIcon.localScale = Vector3.one * 0.6f;
        return returnValue;
    }

    // cast 2 separate rays from each controller to the point where you are aiming
    void UpdateRaycastLine()
    {
        raycastLineLeft.SetPosition(0, OVRInput.GetLocalControllerPosition(OVRInput.Controller.LTouch));
        raycastLineRight.SetPosition(0, OVRInput.GetLocalControllerPosition(OVRInput.Controller.RTouch));
        raycastLineLeft.SetPosition(1, targetingIconLeft.position);
        raycastLineRight.SetPosition(1, targetingIconRight.position);
    }

    // toggle on and off if you want the rays to be visible, but they will still be casted
    void ToggleRayVisibility()
    {
        rayVisible = !rayVisible;
        raycastLineLeft.enabled = rayVisible;
        raycastLineRight.enabled = rayVisible;
    }

    struct RaycastResult
    {
        public Vector3 position;
        public Vector3 scale;
    }
}