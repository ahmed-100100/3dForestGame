using UnityEngine;
public class TestSpawn : MonoBehaviour
{
    public GameObject skeletonPrefab;

    void Start()
    {
        Instantiate(skeletonPrefab, new Vector3(0, 0, 0), Quaternion.identity);
    }
}
