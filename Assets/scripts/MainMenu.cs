using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip buttonSound;

    public void PlayGame() {
        StartCoroutine(PlaySoundAndLoadScene("Main"));
    }

    public void GoToOptionsMenu() {
        StartCoroutine(PlaySoundAndLoadScene("OptionsMenu"));
    }

    public void GoToMainMenu() {
        StartCoroutine(PlaySoundAndLoadScene("MainMenu"));
    }

    public void QuitGame() {
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
