using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class RaycastPlaceObject : MonoBehaviour
{
    // standard offset is set on 0 but set the Y on a certain value to make the object hover above the ground
    // but we set it on 0.01f to avoid the object to be clipped in the ground
    [SerializeField] private bool rayVisible;

    [Header("You won't be able to move the spawned object if set to true")] 
    [SerializeField] private bool isAnchored = false;
    [SerializeField] private GameObject objectToPlace;
    [SerializeField] private int maxObjects = 1;
    [SerializeField] private Vector3 offset;

    [Header("Specify the buttons we want to use to spawn objects")]
    [SerializeField] private OVRInput.RawButton[] leftButtons;
    [SerializeField] private OVRInput.RawButton[] rightButtons;

    [SerializeField] private Transform targetingIconLeft;
    [SerializeField] private Transform targetingIconRight;

    [SerializeField] private LineRenderer rayCastLineLeft;
    [SerializeField] private LineRenderer rayCastLineRight;
    [SerializeField] private float lineWidth = 0.01f;

    [SerializeField] private LayerMask sceneLayer;
    [SerializeField] private Vector3 handOffset;

    private float switchDelay = 0.1f; 
    private bool isSwitching = false;

    Queue<GameObject> placedObjects = new();
    OVRInput.Controller activeController = OVRInput.GetActiveController();

    private void Start()
    {
#pragma warning disable CS0618
        rayCastLineLeft.SetWidth(lineWidth, lineWidth);
        rayCastLineRight.SetWidth(lineWidth, lineWidth);
#pragma warning restore CS0618
    }

    private void Update()
    {
        activeController = OVRInput.GetActiveController();
        OffsetCalculation();
        ToggleRayVisibility();
        UpdateRayCastLine();
    }

    private void UpdateRayCastLine()
    {
        rayCastLineLeft.SetPosition(1, targetingIconLeft.position);
        rayCastLineRight.SetPosition(1, targetingIconRight.position);

        if (activeController == OVRInput.Controller.Hands)
        {
            var hand = GetComponentInChildren<OVRHand>();
          
            var (leftResult, leftPosition) = HandRayCast(OVRInput.Controller.LHand, targetingIconLeft);
            var (rightResult, rightPosition) = HandRayCast(OVRInput.Controller.RHand, targetingIconRight);

            if (!isSwitching)
            {
                StartCoroutine(SwitchDelayCoroutine()); 
            }

            rayCastLineLeft.SetPosition(0, hand.PointerPose.localPosition);
            rayCastLineRight.SetPosition(0, hand.PointerPose.localPosition);
        }
        if (activeController == OVRInput.Controller.Touch)
        {
            ControllerRayCast(OVRInput.Controller.LTouch, leftButtons, targetingIconLeft);
            ControllerRayCast(OVRInput.Controller.RTouch, rightButtons, targetingIconRight);

            if (!isSwitching) 
            {
                StartCoroutine(SwitchDelayCoroutine()); 
            }

            rayCastLineLeft.SetPosition(0, OVRInput.GetLocalControllerPosition(OVRInput.Controller.LTouch));
            rayCastLineRight.SetPosition(0, OVRInput.GetLocalControllerPosition(OVRInput.Controller.RTouch));
        }
    }

    IEnumerator SwitchDelayCoroutine()
    {
        isSwitching = true; // set flag to switch state
        yield return new WaitForSeconds(switchDelay); // wait for delay time
        isSwitching = false; // reset flag to not switch state
    }

    // if there is no offset then we don't want to calculate the offset thus saving performance
    private void OffsetCalculation()
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
    private ControllerRayCastResult ControllerRayCast(OVRInput.Controller controller, OVRInput.RawButton[] buttons, Transform targetIcon)
    {
        var returnValue = new ControllerRayCastResult();
        var rayPos = OVRInput.GetLocalControllerPosition(controller);
        var rayFwd = OVRInput.GetLocalControllerRotation(controller) * Vector3.forward;
        if (Physics.Raycast(rayPos, rayFwd, out var hitInfo, 1000.0f, sceneLayer))
        {
            // if hitting a vertical surface, drop quad to the floor this only works when we use targeting icon instead of cursor icon
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

        // Not necessary for the object to have the right rotation since that happens in another script
        placedObjects.Enqueue(Instantiate(objectToPlace, position, Quaternion.identity));
        if (maxObjects > 0 && placedObjects.Count > maxObjects)
        {
            Destroy(placedObjects.Dequeue());
        }

        targetIcon.localScale = Vector3.one * 0.6f;
        return returnValue;
    }

    private bool isPinching;

    private (HandRayCastResult, Vector3) HandRayCast(OVRInput.Controller controller, Transform targetIcon)
    {
        var returnValue = new HandRayCastResult();
        var hand = GetComponentInChildren<OVRHand>();
        var isIndexFingerPinching = hand.GetFingerIsPinching(OVRHand.HandFinger.Index);
        var indexFingerTipPosition = hand.PointerPose.localPosition;
        var indexFingerDirection = hand.PointerPose.localRotation * Vector3.forward;

        if (Physics.Raycast(indexFingerTipPosition, indexFingerDirection, out var hitInfo, 1000.0f, sceneLayer))
        {
            // if hitting a vertical surface, drop quad to the floor this only works when we use targeting icon instead of cursor icon
            var iconHeight = Mathf.Abs(Vector3.Dot(Vector3.up, hitInfo.normal)) < 0.5f ? 0 : hitInfo.point.y;
            // offset quad a bit so it doesn't z-flicker
            targetIcon.position = new Vector3(hitInfo.point.x, iconHeight + 0.01f, hitInfo.point.z);
        }

        var position = hitInfo.point + offset;

        if (isIndexFingerPinching && !isPinching)
        {
            isPinching = true;

            // anchor all the objects so we don't spawn any new objects, thus not being able to move the objects
            if (isAnchored && maxObjects == placedObjects.Count)
            {
                return (returnValue, position);
            }

            // Not necessary for the object to have the right rotation since that happens in another script
            placedObjects.Enqueue(Instantiate(objectToPlace, position, Quaternion.identity));
            if (maxObjects > 0 && placedObjects.Count > maxObjects)
            {
                Destroy(placedObjects.Dequeue());
            }
            return (returnValue, position);
        }
        // Only allow pinching to spawn objects once per pinch
        if (!isIndexFingerPinching && isPinching)
        {
            isPinching = false;
        }

        targetIcon.localScale = Vector3.one * 0.6f;
        return (returnValue, position);
    }

    private void ToggleRayVisibility()
    {
        rayCastLineLeft.gameObject.SetActive(rayVisible);
        rayCastLineRight.gameObject.SetActive(rayVisible);
    }

    private struct ControllerRayCastResult
    {
        public Vector3 position;
        public Vector3 scale;
    }

    private struct HandRayCastResult
    { 
        public Vector3 position;
        public Vector3 scale;
    }
}