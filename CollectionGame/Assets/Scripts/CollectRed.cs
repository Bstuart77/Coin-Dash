using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectRed : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            other.GetComponent<Movement>().points++;
            KeepScore.Score += 3;
            Debug.Log("test");
            Destroy(gameObject);
        }
    }
}
