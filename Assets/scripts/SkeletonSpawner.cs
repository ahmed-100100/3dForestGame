using UnityEngine;
using System.Collections;

public class SkeletonSpawner : MonoBehaviour
{
    public GameObject skeletonPrefab; 
    public Transform player;         
    public float minDelay = 3f;
    public float maxDelay = 6f;
    public float spawnDistanceInFront = 3f;

    private bool spawned = false;

    void Start()
    {
        StartCoroutine(SpawnSkeleton());
    }

    IEnumerator SpawnSkeleton()
    {
        float delay = Random.Range(minDelay, maxDelay);
        yield return new WaitForSeconds(delay);

        if (!spawned && player != null)
        {
            Vector3 forwardDirection = player.forward.normalized;
            forwardDirection.y = 0; 

            Vector3 spawnPosition = player.position + forwardDirection * spawnDistanceInFront;
            Instantiate(skeletonPrefab, spawnPosition, Quaternion.identity);

            spawned = true;
            Debug.Log("Skeleton Spawned!");
        }
    }
}

