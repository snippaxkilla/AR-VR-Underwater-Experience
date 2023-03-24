using UnityEngine;

public class DisableScript : MonoBehaviour
{
    OVRInput.Controller activeController = OVRInput.GetActiveController();

    private void Start()
    {
        DisableAllScripts();
    }

    private void Update()
    {
        if (activeController == OVRInput.Controller.Hands)
        {
            EnableAllScripts();
        }
        else
        {
            DisableAllScripts();
        }
    }

    private void DisableAllScripts()
    {
        var scripts = GetComponents<MonoBehaviour>();

        foreach (var script in scripts)
        {
            if (script != this)
            {
                script.enabled = false;
            }
        }
    }

    private void EnableAllScripts()
    {
        var scripts = GetComponents<MonoBehaviour>();

        foreach (var script in scripts)
        {
            if (script != this)
            {
                script.enabled = true;
            }
        }
    }
}
