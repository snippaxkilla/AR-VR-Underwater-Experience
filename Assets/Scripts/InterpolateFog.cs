using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class InterpolateFog : MonoBehaviour
{
    [SerializeField] private Color startColor;
    [SerializeField] private float duration;

    private Coroutine fogCoroutine; // Hold a reference to the running coroutine

    public enum FogStates
    {
        S100,
        S75,
        S50,
        S25,
        S0
    }

    private Dictionary<FogStates, (Color, int, int)> fogStateSettings = new()
    {
        {FogStates.S100, (Color.clear, 0, 100)},
        {FogStates.S75, (Color.blue, 8, 20)},
        {FogStates.S50, (Color.cyan, 6, 40)},
        {FogStates.S25, (Color.gray, 4, 60)},
        {FogStates.S0, (Color.black, 2, 80)}
    };

    private void Update()
    {
        var playerScore = GarbageCollector.Instance.GetGarbageCollectedCount();

        FogStates currentState;
        switch (playerScore)
        {
            case >= 100:
                currentState = FogStates.S100;
                break;
            case >= 75:
                currentState = FogStates.S75;
                break;
            case >= 50:
                currentState = FogStates.S50;
                break;
            case >= 25:
                currentState = FogStates.S25;
                break;
            default:
                currentState = FogStates.S0;
                break;
        }

        FogChange(currentState);
    }

    public void FogChange(FogStates currentState)
    {
        if (fogStateSettings.ContainsKey(currentState))
        {
            var settings = fogStateSettings[currentState];
            startColor = RenderSettings.fogColor;
            RenderSettings.fogStartDistance = settings.Item2;
            RenderSettings.fogEndDistance = settings.Item3;

            if (fogCoroutine != null)
            {
                StopCoroutine(fogCoroutine); 
            }
            fogCoroutine = StartCoroutine(InterpolateFogColor(settings.Item1));
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
