using UnityEngine;

public class Cactus : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ScoreManager.instance.AddScore(-1); 
            Destroy(gameObject); 
        }
    }
}
