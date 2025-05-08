using UnityEngine;
using System.Collections;

public class SkeletonSpawner : MonoBehaviour
{
    public GameObject skeletonPrefab;
    public Transform player;
    public float initialMinDelay = 3f;
    public float initialMaxDelay = 6f;
    public float spawnDistanceInFront = 3f;
    public float difficultyIncreaseInterval = 15f;
    public float delayDecreaseAmount = 0.5f;
    public float minLimitDelay = 0.5f;

    private float currentMinDelay;
    private float currentMaxDelay;
    private float difficultyTimer = 0f;

    void Start()
    {
        currentMinDelay = initialMinDelay;
        currentMaxDelay = initialMaxDelay;
        StartCoroutine(SpawnLoop());
    }

    IEnumerator SpawnLoop()
    {
        while (true)
        {
            float delay = Random.Range(currentMinDelay, currentMaxDelay);
            yield return new WaitForSeconds(delay);

            if (player != null)
            {
                Vector3 forward = player.forward.normalized;
                forward.y = 0;

                Vector3 spawnPosition = player.position + forward * spawnDistanceInFront;
                Instantiate(skeletonPrefab, spawnPosition, Quaternion.identity);
                Debug.Log("Skeleton Spawned!");
            }

            difficultyTimer += delay;
            if (difficultyTimer >= difficultyIncreaseInterval)
            {
                difficultyTimer = 0f;

                currentMinDelay = Mathf.Max(minLimitDelay, currentMinDelay - delayDecreaseAmount);
                currentMaxDelay = Mathf.Max(minLimitDelay + 0.1f, currentMaxDelay - delayDecreaseAmount);

                Debug.Log("Difficulty increased! New delay range: " + currentMinDelay + " to " + currentMaxDelay);
            }
        }
    }
}
