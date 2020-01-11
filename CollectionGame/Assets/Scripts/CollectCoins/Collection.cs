using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collection : MonoBehaviour
{
    private void Update()
    {
        if (gameObject.name == "Coin(Clone)")
        {
            Destroy(gameObject, 5);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            KeepScore.Score += 1;
            Ultimate.ult += 3;
            Destroy(gameObject);
        }
    }
}
