using UnityEngine;

public class JumpDebug : MonoBehaviour
{
    [SerializeField] private Rigidbody testRigidbody;
    [SerializeField] private float jumpForce = 5f;

    void FixedUpdate()
    {
        Jump();
    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    private bool IsGrounded()
    {
        return Physics.Raycast(transform.position, Vector3.down, 0.1f);
    }
}