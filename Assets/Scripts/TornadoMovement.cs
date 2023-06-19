using UnityEngine;

public class TornadoMovement : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 14f;

    private float bobMin = -0.5f, bobMax = 0.5f;
    private float bobSpeed = 0.01f;

    private void Update()
    {
        RotateTornado();
    }

    // the tornado rotates around the y axis, but we also rotate the x and z axis between 2 values
    private void RotateTornado()
    {
        transform.Rotate(0, rotationSpeed, 0);

        transform.rotation = Quaternion.Euler(Mathf.Lerp(bobMin, bobMax, Mathf.PingPong(Time.time * bobSpeed, 1)), 
            transform.rotation.eulerAngles.y, Mathf.Lerp(bobMin, bobMax, Mathf.PingPong(Time.time * bobSpeed, 1)));
    }
}
