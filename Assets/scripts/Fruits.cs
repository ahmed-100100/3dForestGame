using UnityEngine;

public class Fruit : MonoBehaviour
{
    public AudioClip collectSound;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            audioSource.PlayOneShot(collectSound);
            ScoreManager.instance.AddScore(1);
            Destroy(gameObject, collectSound.length/2);
        }
    }
}
