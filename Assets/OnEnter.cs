using UnityEngine;

public class OnEnter : MonoBehaviour
{
    public GameObject[] objectsToEnable;
    private string playerTag;
    private bool objectsActive = false;

    void Start()
    {
        playerTag = "Player";
        SetObjectsActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == playerTag && !objectsActive)
        {
            SetObjectsActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == playerTag && objectsActive)
        {
            SetObjectsActive(false);
        }
    }

    void SetObjectsActive(bool active)
    {
        foreach (GameObject obj in objectsToEnable)
        {
            obj.SetActive(active);
        }
        objectsActive = active;
    }
}

