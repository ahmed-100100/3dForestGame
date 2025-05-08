using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public GameObject win;
    public AudioSource audioSource;
    public AudioClip winSound;
    public static ScoreManager instance;

    public int score = 0;
    public Text scoreText;

    public int targetScore = 10; // win for level1

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
            win.SetActive(true);
            audioSource?.PlayOneShot(winSound);
            Time.timeScale = 0f;
        }
        else if (currentScene == "Level2" && score >= 30)
        {
              win.SetActive(true);
            audioSource?.PlayOneShot(winSound);
            Time.timeScale = 0f;
        }
    }
}
