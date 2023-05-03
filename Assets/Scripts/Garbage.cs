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

    public enum GarbageState
    {
        Drowning,
        Floating,
        Retracting,
        Stopped
    }

    [SerializeField] private Rigidbody garbageRigidbody;

    [Header("Garbage size doesn't influence the retract speed, it groups it into spawning types")]
    [SerializeField] private GarbageSize size;
    [Header("The amount of points will change the environment")]
    [SerializeField] private int points;
    [Header("How fast will my garbage retract by my grappling hook")]
    [SerializeField] private float retractSpeed = 1f;
    [Header("How fast will my garbage drown, base is 0.05, the higher you go the slower it will fall")]
    [SerializeField] private float drowningSpeed = 1f;
    [Header("The time it will take to transition back to floating state")]
    [SerializeField] private float drowningTime = 2f;
    [SerializeField] private float floatingSmoothTime = 0.5f;

    private Vector3 targetVelocity;
    private Vector3 currentVelocity;
    private GarbageState garbageState;
    private Coroutine drowningCoroutine;

    private void Start()
    {
        garbageState = GarbageState.Drowning;
        garbageRigidbody.angularDrag = drowningSpeed;
        drowningCoroutine = StartCoroutine(Drowning());
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

                // TODO: Implement retracting

                break;
            case GarbageState.Stopped:
                break;
        }
    }

    private IEnumerator Drowning()
    {
        yield return new WaitForSeconds(drowningTime);
        SetState(GarbageState.Floating);
    }

    private void Drown()
    {
        garbageRigidbody.useGravity = true;
    }

    private void Float()
    {
        garbageRigidbody.useGravity = false;
        targetVelocity = Vector3.zero;

        // Smoothly damp the velocity
        currentVelocity = Vector3.SmoothDamp(garbageRigidbody.velocity, targetVelocity, ref currentVelocity, floatingSmoothTime);
        garbageRigidbody.velocity = currentVelocity;

        // Check if the object has almost reached its target velocity
        if (Vector3.Distance(currentVelocity, targetVelocity) < 0.01f)
        {
            garbageRigidbody.velocity = Vector3.zero;
            SetState(GarbageState.Stopped);
        }
    }

    public void SetState(GarbageState newState)
    {
        if (garbageState == newState) return;

        if (drowningCoroutine != null)
        {
            StopCoroutine(drowningCoroutine);
            drowningCoroutine = null;
        }

        garbageState = newState;
    }

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