using System.Collections;
using UnityEngine;

public class Garbage : MonoBehaviour
{
    public enum GarbageSize
    {
        Small,
        Medium,
        Large
    }

    private enum GarbageState
    {
        Drowning,
        Floating,
        Retracting
    }

    [SerializeField] private Rigidbody garbageRigidbody;

    [Header("Garbage size doesn't influence the retract speed it groups it into spawning types")]
    [SerializeField] private GarbageSize size;
    [Header("The amount of points will change the environment")]
    [SerializeField] private int points;
    [Header("How fast will my garbage retract by my grappling hook")]
    [SerializeField] private float retractSpeed = 1f;
    [Header("How fast will my garbage drown, base is 0.05 the higher you go to slower it will fall")]
    [SerializeField] private float drowningSpeed = 1f;
    [Header("The time it will take to transition back to floating state")]
    [SerializeField] private float drowningTime = 2f;

    private GarbageState garbageState;

    private bool isIdle = false;

    private void Start()
    {
        garbageState = GarbageState.Drowning;
        garbageRigidbody.angularDrag = drowningSpeed;
    }

    private void Update()
    {
        switch (garbageState)
        {
            case GarbageState.Drowning:
                Drown();
                break;
            case GarbageState.Floating:
                Float();
                break;
            case GarbageState.Retracting:
                //Retract();
                break;
        }
    }

    private IEnumerator Drowning()
    {
        yield return new WaitForSeconds(drowningTime);
        garbageState = GarbageState.Floating;
    }

    private void Drown()
    {
        StartCoroutine(Drowning());
        garbageRigidbody.useGravity = true;
    }

    private void Float()
    {
        if (isIdle) return;
        garbageRigidbody.useGravity = false;
        garbageRigidbody.velocity = Vector3.zero;
        isIdle = true;
    }

    //private void Retract()
    //{
        
    //    garbageState = GarbageState.Retracting;
    //}

    public GarbageSize GetSize()
    {
        return size;
    }

    public int GetPoints()
    {
        return points;
    }

    public float GetRetractSpeed()
    {
        return retractSpeed;
    }
}