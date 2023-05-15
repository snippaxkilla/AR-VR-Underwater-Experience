using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wiggle : MonoBehaviour
{

    private GameObject objectToBob;

    public float amplitudeX = 1f; // set to 0 if no x bob
    public float frequencyX = 1f; // boobing speed in x
    public float amplitudeY = 1f; // set to 0 if no y bob
    public float frequencyY = 1f; // bobbing speed in y

    private Vector3 refPos;

    public void Start()
    {
        if (objectToBob == null)
        {
            objectToBob = this.gameObject;
        }
        refPos = objectToBob.transform.position;
    }

    public void Update()
    {
        float dx = amplitudeX * (Mathf.PerlinNoise(Time.time * frequencyX, 1f) - 0.5f);
        float dy = amplitudeY * (Mathf.PerlinNoise(1f, Time.time * frequencyY) - 0.5f);
        Vector3 pos = new Vector3(refPos.x, refPos.y, refPos.z);
        pos = pos + objectToBob.transform.up * dy;
        pos = pos + objectToBob.transform.right * dx;
        objectToBob.transform.position = pos;
    }
}