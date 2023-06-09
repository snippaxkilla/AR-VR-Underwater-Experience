using UnityEngine;

public class Caught : MonoBehaviour
{
    [Tooltip("Maximum time a caught object will stay in the tornado")]
    [SerializeField] private float maxCaughtTime = 5.0f;

    private Tornado tornadoReference;
    private SpringJoint spring;

    [HideInInspector]
    [SerializeField] public Rigidbody rigidBody;

    // You may want to introduce a variable for update frequency.
    private float updateFrequency = 1f;
    private float nextUpdateTime;
    private float caughtTime = 0;

    private void Awake()
    {
        nextUpdateTime = Time.time;
    }

    private void Update()
    {
        if (Time.time >= nextUpdateTime)
        {
            // Lift spring so objects are pulled upwards
            Vector3 newPosition = spring.connectedAnchor;
            newPosition.y = transform.position.y + tornadoReference.lift / 10.0f;
            spring.connectedAnchor = newPosition;

            nextUpdateTime = Time.time + updateFrequency;
        }

        caughtTime += Time.deltaTime;
        if (caughtTime >= maxCaughtTime)
        {
            Release();
        }
    }

    private void FixedUpdate()
    {
        //Rotate object around tornado center
        Vector3 direction = transform.position - tornadoReference.transform.position;
        //Project
        Vector3 projection = Vector3.ProjectOnPlane(direction, tornadoReference.GetRotationAxis());
        projection.Normalize();
        Vector3 normal = Quaternion.AngleAxis(130, tornadoReference.GetRotationAxis()) * projection;
        normal = Quaternion.AngleAxis(tornadoReference.lift, projection) * normal;
        rigidBody.AddForce(normal * tornadoReference.GetStrength(), ForceMode.Force);

#if UNITY_EDITOR
        Debug.DrawRay(transform.position, normal * 10, Color.red);
#endif
    }

    //Call this when tornadoReference already exists
    public void Init(Tornado tornadoRef, Rigidbody tornadoRigidbody, float springForce)
    {
        // Save references to the tornado and rigidbody
        tornadoReference = tornadoRef;
        rigidBody = GetComponent<Rigidbody>();

        //Initialize the spring
        spring = gameObject.AddComponent<SpringJoint>();
        spring.spring = springForce;
        spring.connectedBody = tornadoRigidbody;

        spring.autoConfigureConnectedAnchor = false;

        //Set initial position of the caught object relative to its position and the tornado
        Vector3 initialPosition = Vector3.zero;
        initialPosition.y = transform.position.y;
        spring.connectedAnchor = initialPosition;
        caughtTime = 0;
    }

    public void Release()
    {
        Destroy(spring);
        Destroy(this);
    }

}