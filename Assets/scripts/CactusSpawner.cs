using UnityEngine;

public class CactusSpawner : MonoBehaviour
{
    public GameObject[] cactusPrefabs; 
    public int numberOfCactus = 20;
    public Vector3 spawnAreaCenter;
    public Vector3 spawnAreaSize;

    void Start()
    {
        SpawnCactus();
    }

    void SpawnCactus()
    {
        // Debug.Log("Spawning cactus...");
        for (int i = 0; i < numberOfCactus; i++)
        {
            Vector3 randomPos = spawnAreaCenter + new Vector3(
                Random.Range(-spawnAreaSize.x / 2, spawnAreaSize.x / 2),
                0f,
                Random.Range(-spawnAreaSize.z / 2, spawnAreaSize.z / 2)
            );

            GameObject randomCactus = cactusPrefabs[Random.Range(0, cactusPrefabs.Length)];
            Instantiate(randomCactus, randomPos, Quaternion.identity);
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireCube(spawnAreaCenter, spawnAreaSize);
    }
}