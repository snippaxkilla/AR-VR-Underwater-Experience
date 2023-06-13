using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class InterpolateFog : MonoBehaviour
{
    [SerializeField] private Color startColor;
    [SerializeField] private float duration;

    //S100 is clear S0 is a lot of fog
    public enum FogStates
    {
        S100,
        S75,
        S50,
        S25,
        S0
    }

    private Dictionary<FogStates, Color> fogStateColors = new()
    {
        {FogStates.S100, Color.clear},
        {FogStates.S75, Color.blue},
        {FogStates.S50, Color.cyan},
        {FogStates.S25, Color.gray},
        {FogStates.S0, Color.black}
    };

    private void Update()
    {
        var playerScore = GarbageCollector.Instance.GetGarbageCollectedCount();

        switch (playerScore)
        {
            case >= 100:
                FogChange(FogStates.S100);
                RenderSettings.fogStartDistance = 0;
                RenderSettings.fogEndDistance = 100;
                break;
            case >= 75:
                FogChange(FogStates.S75);
                RenderSettings.fogStartDistance = 8;
                RenderSettings.fogEndDistance = 20;
                break;
            case >= 50:
                FogChange(FogStates.S50);
                RenderSettings.fogStartDistance = 6;
                RenderSettings.fogEndDistance = 40;
                break;
            case >= 25:
                FogChange(FogStates.S25);
                RenderSettings.fogStartDistance = 4;
                RenderSettings.fogEndDistance = 60;
                break;
            default:
                FogChange(FogStates.S0);
                RenderSettings.fogStartDistance = 2;
                RenderSettings.fogEndDistance = 80;
                break;
        }
        //if (!Input.GetKeyDown("space")) return;
        //FogChange(FogStates.S0);
        //Debug.Log("Space key pressed, changing fog to s0 state");
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