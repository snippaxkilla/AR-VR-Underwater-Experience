using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class InterpolateFog : MonoBehaviour
{
    [SerializeField] private Color startColor;
    [SerializeField] private float duration;

    public enum FogStates
    {
        S100,
        S75,
        S50,
        S25,
        S0
    }

    //TODO: change the colors here to match the colors in the fogStateColors dictionary
    private Dictionary<FogStates, Color> fogStateColors = new()
    {
        {FogStates.S100, Color.blue},
        {FogStates.S75, Color.gray},
        {FogStates.S50, Color.gray},
        {FogStates.S25, Color.red},
        {FogStates.S0, Color.clear}
    };

    private void Update()
    {
        if (!Input.GetKeyDown("space")) return;
        FogChange(FogStates.S0);
        Debug.Log("Space key pressed, changing fog to s0 state");
    }

    public void FogChange(FogStates currentState)
    {
        if (fogStateColors.ContainsKey(currentState))
        {
            startColor = RenderSettings.fogColor;
            Color endColor = fogStateColors[currentState];
            StartCoroutine(InterpolateFogColor(endColor));
        }
        else
        {
            Debug.LogError("Invalid FogState: " + currentState);
        }
    }

    private IEnumerator InterpolateFogColor(Color endColor)
    {
        var timeElapsed = 0f;
        RenderSettings.fogColor = startColor;

        while (timeElapsed < duration)
        {
            timeElapsed += Time.deltaTime;
            var t = timeElapsed / duration;
            RenderSettings.fogColor = Color.Lerp(startColor, endColor, t);
            yield return null;
        }

        RenderSettings.fogColor = endColor;
    }
}