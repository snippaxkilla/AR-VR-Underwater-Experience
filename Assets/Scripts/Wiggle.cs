using UnityEngine;

public class Wiggle : MonoBehaviour
{
    private GameObject objectToBob;

    [SerializeField] private float amplitudeX = 1f; // set to 0 if no x bob
    [SerializeField] private float frequencyX = 1f; // boobing speed in x
    [SerializeField] private float amplitudeY = 1f; // set to 0 if no y bob
    [SerializeField] private float frequencyY = 1f; // bobbing speed in y

    private Vector3 refPos;

    private void Start()
    {
        if (objectToBob == null)
        {
            objectToBob = gameObject;
        }
        refPos = objectToBob.transform.position;
    }

    private void Update()
    {
        var dx = amplitudeX * (Mathf.PerlinNoise(Time.time * frequencyX, 1f) - 0.5f);
        var dy = amplitudeY * (Mathf.PerlinNoise(1f, Time.time * frequencyY) - 0.5f);
        var pos = new Vector3(refPos.x, refPos.y, refPos.z);
        pos = pos + objectToBob.transform.up * dy;
        pos = pos + objectToBob.transform.right * dx;
        objectToBob.transform.position = pos;
    }
}