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
    [SerializeField] private float pullbackSpeed;

    public GarbageSize GetSize()
    {
        return size;
    }

    public int GetPoints()
    {
        return points;
    }

    public float GetPullbackSpeed()
    {
        return pullbackSpeed;
    }
}