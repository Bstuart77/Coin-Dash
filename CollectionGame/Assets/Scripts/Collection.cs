using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collection : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            other.GetComponent<Movement>().points++;
            KeepScore.Score += 1;
            Destroy(gameObject);
        }
    }
}
