using UnityEngine;
using System.Collections;


public class InterpolateFog : MonoBehaviour
{
    public Color startColor; // the starting color of the fog
    public Color endColor; // the ending color of the fog
    public float duration; // the duration of the interpolation, in seconds

    
    public enum FogStates // fog states, starting from dark fog to light blue clear fog
    {
        s100, // max fog color
        s75,
        s50,
        s25,
        s0 // clear fog color
    }

   // public FogStates currentState;

    private void Update()
    {
        if (Input.GetKeyDown("space"))
        {
           // currentState = FogStates.s0;
            fogChange(FogStates.s0);
            Debug.Log("");
        }
    }

    public void fogChange(FogStates currentState)
    {
        switch (currentState)
        {
            case FogStates.s100:
                // startColor = Color.black;
                endColor = Color.blue;
                StartCoroutine(InterpolateFogColor()); // start the coroutine to interpolate the fog color

                break;
            case FogStates.s75:
                startColor = RenderSettings.fogColor;
                endColor = Color.gray;
                StartCoroutine(InterpolateFogColor()); // start the coroutine to interpolate the fog color

                break;
            case FogStates.s50:
                startColor = RenderSettings.fogColor;
                endColor = Color.gray;
                StartCoroutine(InterpolateFogColor()); // start the coroutine to interpolate the fog color

                break;
            case FogStates.s25:
                startColor = RenderSettings.fogColor;
                endColor = Color.red;
                StartCoroutine(InterpolateFogColor()); // start the coroutine to interpolate the fog color

                break;
            case FogStates.s0:
                startColor = RenderSettings.fogColor;
                endColor = Color.clear;
                StartCoroutine(InterpolateFogColor()); // start the coroutine to interpolate the fog color

                break;
        }
    }


    IEnumerator InterpolateFogColor()
    {
        float timeElapsed = 0f; // initialize the time elapsed
        RenderSettings.fogColor = startColor; // set the starting color of the fog

        while (timeElapsed < duration)
        {
            timeElapsed += Time.deltaTime; // increase the time elapsed by the amount of time since the last frame
            float t = timeElapsed / duration; // calculate the interpolation factor
            RenderSettings.fogColor = Color.Lerp(startColor, endColor, t); // interpolate the fog color between the start and end colors
            yield return null; // wait for the next frame before continuing the loop
        }

        RenderSettings.fogColor = endColor; // set the final color of the fog
    }

    
}
