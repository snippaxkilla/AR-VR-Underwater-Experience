using UnityEngine;

public class HookDebugger : MonoBehaviour
{

    [SerializeField] private GameObject claw;
    [SerializeField] private float amountOfForce = 30f;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var clawRigidbody = claw.GetComponent<Rigidbody>();
            clawRigidbody.AddForce(Vector3.up * amountOfForce, ForceMode.Impulse);
        }
    }
}
