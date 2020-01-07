using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectBlue : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            other.GetComponent<Movement>().points++;
            KeepScore.Score += 10;
            Ultimate.ult += 10;
            Destroy(gameObject);
        }
    }
}
