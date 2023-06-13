using UnityEngine;

public class GarbageCollector : MonoBehaviour
{
    public static GarbageCollector Instance { get; private set; }

    [SerializeField] private int garbageCollectedCount = 0;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public int GetGarbageCollectedCount()
    {
        return garbageCollectedCount;
    }

    public void IncrementGarbageCount(int getPoints)
    {
        garbageCollectedCount++;
    }
}