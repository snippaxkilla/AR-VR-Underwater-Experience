using TMPro;
using UnityEngine;

public class ScoreUpdater : MonoBehaviour
{
    private TextMeshProUGUI scoreText;

    private void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        var playerScore = GarbageCollector.Instance.GetGarbageCollectedCount();
        scoreText.SetText("Score: " + playerScore);
    }
}