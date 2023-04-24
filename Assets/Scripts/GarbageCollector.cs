using UnityEngine;

public class GarbageCollector : MonoBehaviour
{
    private int garbageCollectedCount = 0;

    public int GetGarbageCollectedCount()
    {
        return garbageCollectedCount;
    }

    public void IncrementGarbageCount(int points)
    {
        garbageCollectedCount += points;
    }
}
