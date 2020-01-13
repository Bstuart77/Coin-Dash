using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectBlue : MonoBehaviour
{

    private void Update()
    {
        if (gameObject.name == "blueCoin(Clone)")
        {
            Destroy(gameObject, 2.5f);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            KeepScore.Score += 10;
            Destroy(gameObject);
        }
        else
        {
            Destroy(other.gameObject, 3);
        }
    }
}
