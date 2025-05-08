using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public int score = 0;
    public Text scoreText;

    public int targetScore = 20;
    public string nextSceneName = "Level2"; 

    void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }

    public void UpdateScore(int amount)
    {
        score += amount;

        if (scoreText != null)
            scoreText.text = "Score : " + score.ToString();

        if (score >= targetScore)
        {
            SceneManager.LoadScene(nextSceneName);
        }
    }
}
