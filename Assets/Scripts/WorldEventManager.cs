using UnityEngine;

public class WorldEventManager : MonoBehaviour
{
    [SerializeField] private GameObject[] WorldEvents;
    [SerializeField] private int[] scoreStages = { 50, 100 };

    private int currentStage = 0;

    private void Start()
    {
        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(false);
        }
    }

    private void Update()
    {
        EnableEventOnScore();
    }

    private void EnableEventOnScore()
    {
        var playerScore = GarbageCollector.Instance.GetGarbageCollectedCount();

        if (currentStage < scoreStages.Length && playerScore >= scoreStages[currentStage])
        {
            WorldEvents[currentStage].SetActive(true);
            currentStage++;
        }
    }
}