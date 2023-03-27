using System.Collections.Generic;
using UnityEngine;

public class BuildHelper : MonoBehaviour
{
    [SerializeField] private List<GameObject> debugGameObjects;
    [SerializeField] private List<GameObject> buildGameObjects;

    // Disable the debuggers since they mess up the build
#if UNITY_ANDROID && !UNITY_EDITOR
    private void Awake()
    {
        foreach (GameObject gameObject in debugGameObjects)
        {
            gameObject.SetActive(false);
        }

        foreach (GameObject gameObject in buildGameObjects)
        {
            gameObject.SetActive(true);
        }
    }
#endif

    // Enable debuggers so we can make faster changes in the editor
#if UNITY_EDITOR
    private void Awake()
    {
        foreach (GameObject gameObject in debugGameObjects)
        {
            gameObject.SetActive(true);
        }

        foreach (GameObject gameObject in buildGameObjects)
        {
            gameObject.SetActive(false);
        }
    }
#endif
}
