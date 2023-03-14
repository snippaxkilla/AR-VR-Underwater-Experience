using UnityEngine;

public class ObjectRiser : MonoBehaviour
{
    [Header("Rise the object")]
    [SerializeField] private float riseSpeed = 1f;
    [SerializeField] private float offset = 0f;
    [SerializeField] private float currentHeight;

    private float objectHeight;
    private float maxHeight;
    public bool isRising = true;

    private void Start()
    {
        // Get the height of the collider and set objectHeight accordingly, with an offset
        var bounds = GetHeightObject(gameObject);
        objectHeight = bounds.size.y + offset;
        currentHeight -= objectHeight;
        maxHeight = objectHeight/2;

        // Spawn the object below the ground
        transform.position = new Vector3(transform.position.x, currentHeight, transform.position.z);
        
        // Ignore collisions with all other colliders in the scene
        Collider[] colliders = Physics.OverlapSphere(transform.position, objectHeight);
        foreach (Collider collider in colliders)
        {
            if (collider != GetComponentInChildren<Collider>())
            {
                Physics.IgnoreCollision(GetComponentInChildren<Collider>(), collider, true);
            }
        }
    }

    private void Update()
    {
        ObjectMaxRiser();
    }

    private void ObjectMaxRiser()
    {
        if (currentHeight < maxHeight)
        {
            currentHeight += riseSpeed * Time.deltaTime;
            currentHeight = Mathf.Clamp(currentHeight, -objectHeight, maxHeight);
            transform.position = new Vector3(transform.position.x, currentHeight, transform.position.z);
        }
        if (!(currentHeight >= maxHeight)) return;
        isRising = false;
        // Enable collisions with all other colliders in the scene
        Collider[] colliders = Physics.OverlapSphere(transform.position, objectHeight);
        foreach (Collider collider in colliders)
        {
            if (collider != GetComponentInChildren<Collider>())
            {
                Physics.IgnoreCollision(GetComponentInChildren<Collider>(), collider, false);
            }
        }
    }

    private Bounds GetHeightObject(GameObject parent)
    {
        var totalHeight = new Bounds(parent.transform.position, Vector3.zero);
        foreach (var children in parent.GetComponentsInChildren<Collider>())
        {
            totalHeight.Encapsulate(children.bounds);
        }
        return totalHeight;
    }
}
