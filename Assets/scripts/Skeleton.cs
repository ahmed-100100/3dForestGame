using UnityEngine;

public class Skeleton : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {          
            GameOver.instance.Finish();    
           
        }
    }
}
