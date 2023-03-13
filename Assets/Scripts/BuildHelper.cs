using System.Collections.Generic;
using UnityEngine;

public class BuildHelper : MonoBehaviour
{
    [SerializeField] private List<GameObject> debugGameObjects;
    [SerializeField] private List<GameObject> buildGameObjects;

#if UNITY_STANDALONE && !UNITY_EDITOR
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
