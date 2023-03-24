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

    [SerializeField] private int maxObjects = 1;
    [SerializeField] private Vector3 offset;
    [SerializeField] private OVRInput.RawButton[] leftButtons;
    [SerializeField] private OVRInput.RawButton[] rightButtons;
    [SerializeField] private GameObject objectToPlace;
    [SerializeField] private Transform targetingIconLeft;
    [SerializeField] private Transform targetingIconRight;
    [SerializeField] private LineRenderer rayCastLineLeft;
    [SerializeField] private LineRenderer rayCastLineRight;
    [SerializeField] private LineRenderer debuggerRayCastHand;
    [SerializeField] private LayerMask sceneLayer;
    [SerializeField] private Vector3 handOffset;

    Queue<GameObject> placedObjects = new();
    OVRInput.Controller activeController = OVRInput.GetActiveController();

    private void Start()
    {
#pragma warning disable CS0618
        rayCastLineLeft.SetWidth(0.01f, 0.01f);
        rayCastLineRight.SetWidth(0.01f, 0.01f);
        debuggerRayCastHand.SetWidth(0.01f, 0.01f);
#pragma warning restore CS0618
    }

    private void Update()
    {
        activeController = OVRInput.GetActiveController();
        OffsetCalculation();
        ToggleRayVisibility();
        UpdateRayCastLineController();
        if (activeController == OVRInput.Controller.Hands)
        {
            HandRayCast(OVRInput.Controller.LHand);
            HandRayCast(OVRInput.Controller.RHand);
        }
        else
        {
            RayCast(OVRInput.Controller.LTouch, leftButtons, targetingIconLeft);
            RayCast(OVRInput.Controller.RTouch, rightButtons, targetingIconRight);
        }
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
    private RayCastResult RayCast(OVRInput.Controller controller, OVRInput.RawButton[] buttons, Transform targetIcon)
    {
        var returnValue = new RayCastResult();
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

    private bool isPinching = false;

    private void HandRayCast(OVRInput.Controller controller)
    {
        var hand = GetComponent<OVRHand>();
        var isIndexFingerPinching = hand.GetFingerIsPinching(OVRHand.HandFinger.Index);
        var indexFingerTipPosition = hand.PointerPose.localPosition;
        var indexFingerDirection = hand.PointerPose.localRotation * Vector3.forward;


        if (Physics.Raycast(indexFingerTipPosition, indexFingerDirection, out var hitInfo, 1000.0f, sceneLayer))
        {
            // if hitting a vertical surface, drop quad to the floor
            var iconHeight = Mathf.Abs(Vector3.Dot(Vector3.up, hitInfo.normal)) < 0.5f ? 0 : hitInfo.point.y;
            // offset quad a bit so it doesn't z-flicker
            indexFingerTipPosition = new Vector3(hitInfo.point.x, iconHeight + 0.01f, hitInfo.point.z);
        }

        var position = hitInfo.point + offset;

        //debuggerRayCastHand.SetPosition(0, indexFingerTipPosition);
        debuggerRayCastHand.SetPosition(0, OVRInput.GetLocalControllerPosition(OVRInput.Controller.LTouch));
        debuggerRayCastHand.SetPosition(1, position);

        if (isIndexFingerPinching && !isPinching)
        {
            isPinching = true;

            // anchor all the objects so we don't spawn any new objects, thus not being able to move the objects
            if (isAnchored && maxObjects == placedObjects.Count)
            {
                return;
            }

            placedObjects.Enqueue(Instantiate(objectToPlace, position, Quaternion.identity));
            if (maxObjects > 0 && placedObjects.Count > maxObjects)
            {
                Destroy(placedObjects.Dequeue());
            }
        }
        // Only allow pinching to spawn objects once per pinch
        else if (!isIndexFingerPinching && isPinching)
        {
            isPinching = false;
        }
    }

    // cast 2 separate rays from each controller to the point where you are aiming
    private void UpdateRayCastLineController()
    {
        rayCastLineLeft.SetPosition(0, OVRInput.GetLocalControllerPosition(OVRInput.Controller.LTouch));
        rayCastLineRight.SetPosition(0, OVRInput.GetLocalControllerPosition(OVRInput.Controller.RTouch));
        rayCastLineLeft.SetPosition(1, targetingIconLeft.position);
        rayCastLineRight.SetPosition(1, targetingIconRight.position);
    }

    // toggle on and off if you want the rays to be visible, but they will still be casted
    private void ToggleRayVisibility()
    {
        rayCastLineLeft.gameObject.SetActive(rayVisible);
        rayCastLineRight.gameObject.SetActive(rayVisible);
        if (rayVisible)
        {
            DisableLineAndPointerOnHands();
        }
    }

    // Be aware that this works but it requires you to press a button to register for the start?
    private void DisableLineAndPointerOnHands()
    {
        switch (activeController)
        {
            case OVRInput.Controller.Hands:
            {
                foreach (Transform child in transform)
                {
                    child.gameObject.SetActive(false);
                }

                break;
            }
            case OVRInput.Controller.Touch:
            {
                foreach (Transform child in transform)
                {
                    child.gameObject.SetActive(true);
                }

                break;
            }
            default:
                foreach (Transform child in transform)
                {
                    child.gameObject.SetActive(true);
                }

                break;
        }
    }

    private struct RayCastResult
    {
        public Vector3 position;
        public Vector3 scale;
    }
}