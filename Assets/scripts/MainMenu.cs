using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip buttonSound;

    public void PlayGame() {
        string currentScene = SceneManager.GetActiveScene().name;
        StartCoroutine(PlaySoundAndLoadScene(currentScene == "Level1" ? "Level1" : "Level1"));
        Time.timeScale = 1f;
    }
    
    public void Level2() {
        string currentScene = SceneManager.GetActiveScene().name;
        StartCoroutine(PlaySoundAndLoadScene(currentScene == "Level2" ? "Level2" : "Level2"));
        Time.timeScale = 1f;
    }

    public void GoToOptionsMenu() {
        StartCoroutine(PlaySoundAndLoadScene("OptionsMenu"));
    }

    public void GoToMainMenu() {
        Time.timeScale = 1f;
        StartCoroutine(PlaySoundAndLoadScene("MainMenu"));
    }

    public void QuitGame() {
        Time.timeScale=1f;
        StartCoroutine(PlaySoundAndQuit());
        
    }

    private IEnumerator PlaySoundAndLoadScene(string sceneName) {
        if (audioSource != null && buttonSound != null) {
            audioSource.PlayOneShot(buttonSound);
            yield return new WaitForSeconds(buttonSound.length);
        }
        SceneManager.LoadScene(sceneName);
    }

    private IEnumerator PlaySoundAndQuit() {
        if (audioSource != null && buttonSound != null) {
            audioSource.PlayOneShot(buttonSound);
            yield return new WaitForSeconds(buttonSound.length);
        }
        Application.Quit();
    }
}
