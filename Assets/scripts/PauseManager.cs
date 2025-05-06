using UnityEngine;

public class PauseManager : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject pauseButton;
    public AudioSource audioSource;
    public AudioClip pauseSound;

    public void Pause()
    {
        if (pauseMenu == null) return;
        audioSource?.PlayOneShot(pauseSound);
        Time.timeScale = 0f;
        pauseMenu.SetActive(true);
        pauseButton.SetActive(false);
    }

    public void Resume()
    {
        audioSource?.PlayOneShot(pauseSound);
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
        pauseButton.SetActive(true);
    }

}