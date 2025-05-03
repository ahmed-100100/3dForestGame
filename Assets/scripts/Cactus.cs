using UnityEngine;

public class Cactus : MonoBehaviour
{
    public AudioClip hurtSound;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            audioSource.PlayOneShot(hurtSound);
            ScoreManager.instance.AddScore(-1);
            Destroy(gameObject, hurtSound.length/2);
        }
    }
}
