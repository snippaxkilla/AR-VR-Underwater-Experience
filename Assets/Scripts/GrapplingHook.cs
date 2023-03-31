using System.Collections;
using System.Linq;
using UnityEngine;

public class GrapplingHook : MonoBehaviour
{
    [SerializeField] private GameObject clawLeft;
    [SerializeField] private GameObject clawRight;
    [SerializeField] private float maxDistance = 10f;
    [SerializeField] private float pullSpeed = 5f;
    [SerializeField] private float forceMagnitude = 15f;

    [Header("Specify the buttons we want to use to shoot out hooks")]
    [SerializeField] private OVRInput.RawButton[] leftButtons;
    [SerializeField] private OVRInput.RawButton[] rightButtons;

    private Vector3 clawLeftInitialPosition;
    private Vector3 clawRightInitialPosition;
    private float clawLeftCurrentDistance;
    private float clawRightCurrentDistance;
    private bool isLeftRetracting = false;
    private bool isRightRetracting = false;
    private float leftLerpStartTime;
    private float rightLerpStartTime;

    private void Start()
    {
        clawLeftInitialPosition = OVRInput.GetLocalControllerPosition(OVRInput.Controller.LTouch);
        clawRightInitialPosition = OVRInput.GetLocalControllerPosition(OVRInput.Controller.RTouch);
    }

    private void Update()
    {
        DistanceChecker();
        ShootHook(OVRInput.Controller.LTouch, leftButtons, clawLeft, ref isLeftRetracting, ref leftLerpStartTime,
            clawLeftInitialPosition, ref clawLeftCurrentDistance);
        ShootHook(OVRInput.Controller.RTouch, rightButtons, clawRight, ref isRightRetracting, ref rightLerpStartTime,
            clawRightInitialPosition, ref clawRightCurrentDistance);
    }

    private void ShootHook(OVRInput.Controller controller, OVRInput.RawButton[] buttons, GameObject claw,
        ref bool isRetracting, ref float lerpStartTime, Vector3 clawInitialPosition, ref float clawCurrentDistance)
    {
        var clawRigidbody = claw.GetComponent<Rigidbody>();

        var rayFwd = OVRInput.GetLocalControllerRotation(controller) * Vector3.forward;

        var pressingButton = buttons.Any(button => OVRInput.GetDown(button, controller));

        if (!pressingButton) return;
        claw.transform.position = clawInitialPosition;
        clawRigidbody.AddForce(rayFwd * forceMagnitude, ForceMode.Impulse);

        isRetracting = false;
        clawCurrentDistance = Vector3.Distance(transform.position, claw.transform.position);
    }

    public IEnumerator RetractHook(GameObject claw, Vector3 clawInitialPosition)
    {
        var isRetracting = true;
        var lerpStartTime = Time.time;

        while (isRetracting)
        {
            var lerpFactor = (Time.time - lerpStartTime) / pullSpeed;
            lerpFactor = Mathf.Clamp01(lerpFactor);
            claw.transform.position = Vector3.Lerp(claw.transform.position, clawInitialPosition, lerpFactor);

            if (lerpFactor >= 1)
            {
                isRetracting = false;
            }

            yield return null;
        }
    }

    private void DistanceChecker()
    {
        if (clawLeftCurrentDistance >= maxDistance)
        {
            StartCoroutine(RetractHook(clawLeft, clawLeftInitialPosition));
        }

        if (clawRightCurrentDistance >= maxDistance)
        {
            StartCoroutine(RetractHook(clawRight, clawRightInitialPosition));
        }
    }
}