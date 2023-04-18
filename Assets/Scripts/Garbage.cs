using System;
using UnityEngine;

public class Garbage : MonoBehaviour
{
    public enum GarbageSize
    {
        Small,
        Medium,
        Large
    }

    [SerializeField] private GarbageSize size;
    [SerializeField] private int points;
    [SerializeField] private float retractSpeed;

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