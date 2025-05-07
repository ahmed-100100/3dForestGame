using UnityEngine;
using UnityEngine.SceneManagement; //load scene

public class Skeleton : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Game Over!");           
            // Time.timeScale = 0f;        
            // SceneManager.LoadScene("MainMenu");
           
        }
    }
}
