using UnityEngine;

public class FishManager : MonoBehaviour
{
    [SerializeField] private GameObject[] fishPrefabs;

    [SerializeField] private int[] scoreStages = { 25, 50, 75, 100 };
    [SerializeField] private int fishPerStage = 5; 

    private int currentStage = 0;
    private int fishTypeIndex = 0; 

    private void Start()
    {
        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(false);
        }
    }

    private void Update()
    {
        EnableFishOnScore();
    }

    private void EnableFishOnScore()
    {
        var playerScore = GarbageCollector.Instance.GetGarbageCollectedCount();

        if (currentStage < scoreStages.Length && playerScore >= scoreStages[currentStage])
        {
            for (int i = 0; i < fishPrefabs.Length; i++)
            {
                string currentFishType = fishPrefabs[i].name;

                int enabledThisStage = 0;
                foreach (Transform child in transform)
                {
                    // Only enable fish of the current type
                    if (child.gameObject.name.StartsWith(currentFishType) && !child.gameObject.activeSelf)
                    {
                        child.gameObject.SetActive(true);
                        enabledThisStage++;

                        if (enabledThisStage >= fishPerStage)
                        {
                            break;
                        }
                    }
                }
            }

            currentStage++;
        }
    }
}