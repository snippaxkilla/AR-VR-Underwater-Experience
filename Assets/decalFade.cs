using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class decalFade : MonoBehaviour
{
    DecalProjector decalProjector;
    public float duration;
    private float fadeValue;
    // Start is called before the first frame update
    void Start()
    {
        decalProjector = GetComponent<DecalProjector>();
        decalProjector.fadeFactor = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void fadeIn()
    {
        StartCoroutine(decalFadeIn(0.8f, duration));
    }

    public void fadeOut()
    {
        StartCoroutine(decalFadeOut(0, duration));
    }

    IEnumerator decalFadeIn(float endValue, float duration)
    {
        float time = 0f;
        float startValue = decalProjector.fadeFactor;

        while (time < duration)
        {
            decalProjector.fadeFactor = Mathf.Lerp(startValue, endValue, time / duration);
            time += Time.deltaTime;
            var t = time / duration;
            
            yield return null;
        }

        decalProjector.fadeFactor = endValue;
    }

    IEnumerator decalFadeOut(float endValue, float duration)
    {
        float time = 0f;
        float startValue = decalProjector.fadeFactor;

        while (time < duration)
        {
            decalProjector.fadeFactor = Mathf.Lerp(startValue, endValue, time / duration);
            time += Time.deltaTime;
            var t = time / duration;

            yield return null;
        }

        decalProjector.fadeFactor = endValue;
    }
}
