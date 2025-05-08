using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public int score = 0;
    public Text scoreText;

    public int targetScore = 20; // win for level1

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

        string currentScene = SceneManager.GetActiveScene().name;

        if (currentScene == "Level1" && score >= targetScore)
        {
            SceneManager.LoadScene("Level2");
        }
        else if (currentScene == "Level2" && score >= 50)
        {
            SceneManager.LoadScene("WinScene");
        }
    }
}
