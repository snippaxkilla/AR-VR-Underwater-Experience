using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RaycastPlaceObject : MonoBehaviour
{

    [SerializeField] private int rayLenght;

    public OVRSceneManager _sceneManager;
    bool _roomReady = false;
    private bool isPlacing;
    public GameObject objectToPlace;
    public Transform _targetingIcon;
    public LayerMask _sceneLayer;

    void Awake()
    {
        _sceneManager.SceneModelLoadedSuccessfully += InitializeRoom;
    }

    void InitializeRoom()
    {
        _roomReady = true;
    }

    void Update()
    {
        Raycast();
    }

    void RaycastCustom()
    {
        RaycastHit hit;

        if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger))
        {
            if (Physics.Raycast(transform.position, transform.forward, out hit, rayLenght))
            {
                isPlacing = true;
                Instantiate(objectToPlace, transform.position, transform.rotation);

            }
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
        if (pressingButton)
        {
            Instantiate(objectToPlace, transform.position, Quaternion.identity);
        }
        _targetingIcon.localScale = Vector3.one * (pressingButton ? 0.6f : 0.5f);
    }

    void CalculateObjectAndGiveOffset()
    {
    }
}
