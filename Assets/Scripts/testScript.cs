using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testScript : MonoBehaviour
{
    public InterpolateFog fogscript;
    // Start is called before the first frame update
    void Start()
    {
        fogscript.fogChange(InterpolateFog.FogStates.s100);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
