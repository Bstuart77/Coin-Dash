using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectRed : MonoBehaviour
{
    private void Update()
    {
        if (gameObject.name == "RedCoin(Clone)")
        {
            Destroy(gameObject, 3.5f);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            KeepScore.Score += 3;
            Destroy(gameObject);
        }
    }

}
