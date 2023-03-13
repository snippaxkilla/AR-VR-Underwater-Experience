using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class cameraShakeTest : MonoBehaviour
{
    CinemachineImpulseSource _impulseSource;
    // Start is called before the first frame update
    void Start()
    {
        _impulseSource = GetComponent<CinemachineImpulseSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shake();
        }
    }

    void Shake()
    {
        _impulseSource.GenerateImpulse();
    }
}
