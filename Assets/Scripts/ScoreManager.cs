using UnityEngine;
using TMPro; // Required for TextMeshPro

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance; // Easy access from other scripts
    public TextMeshProUGUI scoreText;
    private int score = 0;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        UpdateScoreText();
    }

    public void AddScore(int points)
    {
        score += points;
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }
}
