using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrapplingHook : MonoBehaviour
{

    [SerializeField] private int clawLength = 100;
    [SerializeField] private LineRenderer clawLine;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void HoldObject()
    {

    }

    private void PullObject()
    {

    }

    private void ReleaseObject()
    {

    }

    private void ShootHook()
    {
        Physics.Raycast(transform.position, transform.forward, out RaycastHit hit, clawLength);
        clawLine.SetPosition(0, transform.position);
        clawLine.SetPosition(1, transform.position);

    }

    private void RetractHook()
    {

    }

    private void HitObject()
    {

    }

}
