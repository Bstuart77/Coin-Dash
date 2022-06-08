using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectGreen : MonoBehaviour
{
    private void Update()
    {
        if (gameObject.name == "greenCoin(Clone)")
        {
            Destroy(gameObject, 3f);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            KeepScore.Score += 5;
            Destroy(gameObject);
        }
    }
}
