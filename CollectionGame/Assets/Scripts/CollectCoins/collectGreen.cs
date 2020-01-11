using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectGreen : MonoBehaviour
{
    private void Update()
    {
        if (gameObject.name == "greenCoin(Clone)")
        {
            Destroy(gameObject, 3.5f);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            KeepScore.Score += 5;
            Ultimate.ult += 8;
            Destroy(gameObject);
        }
    }
}
