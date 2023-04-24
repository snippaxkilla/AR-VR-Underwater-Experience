using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class ForceSyncController : MonoBehaviour
{
    public OVRInput.Controller leftController;
    public OVRInput.Controller rightController;

    void Update()
    {
        OVRInput.Update();

        if (OVRInput.GetDown(OVRInput.Button.Four))
        {
            StartCoroutine(ForceSyncControllers());
        }
    }

    IEnumerator ForceSyncControllers()
    {
        XRInputSubsystem inputSubsystem = null;
        List<XRInputSubsystem> inputSubsystems = new List<XRInputSubsystem>();
        SubsystemManager.GetInstances(inputSubsystems);

        if (inputSubsystems.Count > 0)
        {
            inputSubsystem = inputSubsystems[0];
        }

        if (inputSubsystem != null)
        {
            inputSubsystem.TryRecenter();

            OVRInput.SetControllerVibration(0.5f, 0.5f, leftController);
            OVRInput.SetControllerVibration(0.5f, 0.5f, rightController);

            yield return new WaitForSeconds(0.1f);

            OVRInput.SetControllerVibration(0, 0, leftController);
            OVRInput.SetControllerVibration(0, 0, rightController);
        }
    }
}