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
        Floating,
        Retracting,
        Drowning
    }

    [Header("Garbage size doesn't influence the retract speed it groups it into spawning types")]
    [SerializeField] private GarbageSize size;
    [Header("The amount of points will change the environment")]
    [SerializeField] private int points;
    [Header("How fast will my garbage retract by my grappling hook")]
    [SerializeField] private float retractSpeed = 1f;
    [Header("How fast will my garbage drown")]
    [SerializeField] private float drowningSpeed = 1f;
    [Header("The time it will take to transition back to floating state")]
    [SerializeField] private float drowningTime = 2f;

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