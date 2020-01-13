using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectTimeExtenstion : MonoBehaviour
{
    private void Update()
    {


        if (gameObject.name == "TimeExtension(Clone)")
        {
            Destroy(gameObject, 3f);
        }
    }
private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            Timer.timeLeft += 5f;
            Destroy(gameObject);
        }
    }
}
