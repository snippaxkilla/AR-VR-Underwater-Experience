using UnityEngine;

public class ObjectRiser : MonoBehaviour
{
    [SerializeField] private float riseSpeed = 1f;
    [SerializeField] private float offset = 0f;
    
    private float maxHeight;
    private float currentHeight;
    private bool isRising = true;

    private void Start()
    {
        // Get the height of the collider and set maxHeight accordingly, with an offset
        maxHeight = GetComponent<Collider>().bounds.size.y + offset;
        currentHeight = 0f;

        // Ignore collisions with all other colliders in the scene
        Collider[] colliders = Physics.OverlapSphere(transform.position, maxHeight);
        foreach (Collider collider in colliders)
        {
            if (collider != GetComponent<Collider>())
            {
                Physics.IgnoreCollision(GetComponent<Collider>(), collider, true);
            }
        }
    }

    private void Update()
    {
        if (currentHeight < maxHeight)
        {
            currentHeight += riseSpeed * Time.deltaTime;
            currentHeight = Mathf.Clamp(currentHeight, 0f, maxHeight);
            transform.position = new Vector3(transform.position.x, currentHeight, transform.position.z);
        }
        else if (isRising)
        {
            // Enable collisions with all other colliders in the scene
            Collider[] colliders = Physics.OverlapSphere(transform.position, maxHeight);
            foreach (Collider collider in colliders)
            {
                if (collider != GetComponent<Collider>())
                {
                    Physics.IgnoreCollision(GetComponent<Collider>(), collider, false);
                }
            }
            isRising = false;
        }
    }
}