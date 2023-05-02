using UnityEngine;

public class AutoAssignTag : MonoBehaviour
{
    [Header("auto assign all children this tag")]
    [SerializeField] private string tagName = "Garbage";

    private void Start()
    {
        var tag = tagName;

        Transform[] children = GetComponentsInChildren<Transform>();
        foreach (Transform child in children)
        {
            child.gameObject.tag = tag;
        }
    }
}
