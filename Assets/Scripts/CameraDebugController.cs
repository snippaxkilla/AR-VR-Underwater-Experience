using UnityEngine;
using System.Collections;

public class CameraDebugController : MonoBehaviour
{
    [SerializeField] private float _normalSpeed = 10.0f;
    [SerializeField] private float _shiftSpeed = 20.0f;
    [SerializeField] private float _speedLimit = 50.0f;
    [SerializeField] private float _cameraSensitivity = 0.6f;

    private Vector3 Mouse_Location = new Vector3(255, 255, 255); //Mouse location on screen during play (Set to near the middle of the screen)
    private float Total_Speed = 1.0f; //Total speed variable for shift


    private void Update()
    {
        //Camera angles based on mouse position
        Mouse_Location = Input.mousePosition - Mouse_Location;
        Mouse_Location = new Vector3(-Mouse_Location.y * _cameraSensitivity, Mouse_Location.x * _cameraSensitivity, 0);
        Mouse_Location = new Vector3(transform.eulerAngles.x + Mouse_Location.x, transform.eulerAngles.y + Mouse_Location.y, 0);
        transform.eulerAngles = Mouse_Location;
        Mouse_Location = Input.mousePosition;

        //Keyboard controls

        var Cam = GetBaseInput();
        if (Input.GetKey(KeyCode.LeftShift))
        {
            Total_Speed += Time.deltaTime;

            Cam = _shiftSpeed * Total_Speed * Cam;
            Cam.x = Mathf.Clamp(Cam.x, -_speedLimit, _speedLimit);
            Cam.y = Mathf.Clamp(Cam.y, -_speedLimit, _speedLimit);
            Cam.z = Mathf.Clamp(Cam.z, -_speedLimit, _speedLimit);
        }
        else
        {
            Total_Speed = Mathf.Clamp(Total_Speed * 0.5f, 1f, 1000f);
            Cam *= _normalSpeed;
        }

        Cam *= Time.deltaTime;

        var newPosition = transform.position;

        if (Input.GetKey(KeyCode.Space))
        {
            //If the player wants to move on X and Z axis only by pressing space (good for re-adjusting angle shots)
            transform.Translate(Cam);
            newPosition.x = transform.position.x;
            newPosition.z = transform.position.z;
            transform.position = newPosition;
        }
        else
        {
            transform.Translate(Cam);
        }
    }

    private static Vector3 GetBaseInput()
    {
        Vector3 Camera_Velocity = new();
        var HorizontalInput = Input.GetAxis("Horizontal"); //Input for horizontal movement
        var VerticalInput = Input.GetAxis("Vertical"); //Input for Vertical movement

        Camera_Velocity += new Vector3(HorizontalInput, 0, 0);
        Camera_Velocity += new Vector3(0, 0, VerticalInput);

        return Camera_Velocity;
    }
}