using System.Linq;
using UnityEngine;

public class GrapplingHook : MonoBehaviour
{
    [SerializeField] private GameObject claw;
    [SerializeField] private float MaxDistance = 10f;
    [SerializeField] private float PullSpeed = 5f;

    [Header("Specify the buttons we want to use to shoot out hooks")]
    [SerializeField] private OVRInput.RawButton[] leftButtons;
    [SerializeField] private OVRInput.RawButton[] rightButtons;

    private float currentDistance = 0;

    private void Start()
    {

    }

    private void Update()
    {
        
    }

    private void ShootHook(OVRInput.Controller controller, OVRInput.RawButton[] buttons)
    {
        Rigidbody claw = transform.GetChild(0).GetComponent<Rigidbody>();

        var rayPos = OVRInput.GetLocalControllerPosition(controller);
        var rayFwd = OVRInput.GetLocalControllerRotation(controller) * Vector3.forward;

        var pressingButton = buttons.Any(button => OVRInput.GetDown(button, controller));

        var forceDirection = new Vector3(0f, 0f, 1f);
        var forceMagnitude = 10f;
        claw.AddForce(forceDirection * forceMagnitude, ForceMode.Impulse);
    }

    private void RetractHook()
    {

    }

    // Retract the hook on max distance if no target has been pulled
    private void DistanceChecker()
    {
        
        RetractHook();
    }
}
