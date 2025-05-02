using UnityEngine;

public class FruitSpawner : MonoBehaviour
{
    public GameObject[] fruitPrefabs; // array to support multiple fruit types
    public int numberOfFruits = 20;
    public Vector3 spawnAreaCenter;
    public Vector3 spawnAreaSize;

    void Start()
    {
        SpawnFruits();
    }

    void SpawnFruits()
    {
        // Debug.Log("Spawning fruits...");
        for (int i = 0; i < numberOfFruits; i++)
        {
            Vector3 randomPos = spawnAreaCenter + new Vector3(
                Random.Range(-spawnAreaSize.x / 2, spawnAreaSize.x / 2),
                0f,
                Random.Range(-spawnAreaSize.z / 2, spawnAreaSize.z / 2)
            );

            GameObject randomFruit = fruitPrefabs[Random.Range(0, fruitPrefabs.Length)];
            Instantiate(randomFruit, randomPos, Quaternion.identity);
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireCube(spawnAreaCenter, spawnAreaSize);
    }
}
