using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectGreen : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            other.GetComponent<Movement>().points++;
            KeepScore.Score += 5;
            Ultimate.ult += 8;
            Destroy(gameObject);
        }
    }
}
