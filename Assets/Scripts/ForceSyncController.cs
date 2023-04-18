using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class ForceSyncController : MonoBehaviour
{
    public OVRInput.Controller leftController;
    public OVRInput.Controller rightController;

    private List<InputDevice> devices = new List<InputDevice>();
    private InputDevice leftDevice;
    private InputDevice rightDevice;

    private void Start()
    {
        GetDevices();
    }

    private void Update()
    {
        OVRInput.Update();

        if (OVRInput.GetDown(OVRInput.Button.Four))
        {
            StartCoroutine(ForceSyncControllers());
        }
    }

    private void GetDevices()
    {
        InputDeviceCharacteristics leftTrackedControllerCharacteristics = InputDeviceCharacteristics.Left | InputDeviceCharacteristics.Controller;
        InputDeviceCharacteristics rightTrackedControllerCharacteristics = InputDeviceCharacteristics.Right | InputDeviceCharacteristics.Controller;

        InputDevices.GetDevicesWithCharacteristics(leftTrackedControllerCharacteristics, devices);
        if (devices.Count > 0)
        {
            leftDevice = devices[0];
        }

        InputDevices.GetDevicesWithCharacteristics(rightTrackedControllerCharacteristics, devices);
        if (devices.Count > 0)
        {
            rightDevice = devices[0];
        }
    }

    private IEnumerator ForceSyncControllers()
    {
        if (leftDevice.isValid && rightDevice.isValid)
        {
            HapticCapabilities capabilities;
            if (leftDevice.TryGetHapticCapabilities(out capabilities) && capabilities.supportsImpulse)
            {
                uint channel = 0;
                var amplitude = 0.5f;
                var duration = 0.1f;
                leftDevice.SendHapticImpulse(channel, amplitude, duration);
            }

            if (rightDevice.TryGetHapticCapabilities(out capabilities) && capabilities.supportsImpulse)
            {
                uint channel = 0;
                var amplitude = 0.5f;
                var duration = 0.1f;
                rightDevice.SendHapticImpulse(channel, amplitude, duration);
            }

            List<XRInputSubsystem> subsystems = new List<XRInputSubsystem>();
            SubsystemManager.GetInstances(subsystems);
            if (subsystems.Count > 0)
            {
                foreach (XRInputSubsystem subsystem in subsystems)
                {
                    subsystem.TryRecenter();
                }
            }

            yield return new WaitForSeconds(0.1f);
        }
    }
}
