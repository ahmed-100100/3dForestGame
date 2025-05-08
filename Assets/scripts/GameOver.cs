using UnityEngine;
public class GameOver : MonoBehaviour
{
    public static GameOver instance;
    public GameObject gameOver;
    public AudioSource audioSource;
    public AudioClip gameOverSound;

    private void Awake()
    {
        instance = this;
    }

    public void Finish()
    {
        gameOver.SetActive(true);
        audioSource?.PlayOneShot(gameOverSound);
        Time.timeScale = 0f;
    }
}
