using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTimeExtenstion : MonoBehaviour
{
    public GameObject theEnemy;
    private int xPos;
    private int zPos;

    void Start()
    {
       
        StartCoroutine(TimeExtenstion());
    }

    IEnumerator TimeExtenstion()
    {

        while (Timer.timeLeft >0)
        {
            xPos = Random.Range(-20, 20);
            zPos = Random.Range(-20, 20);
            Instantiate(theEnemy, new Vector3(xPos, 1.61f, zPos), theEnemy.transform.rotation);

            yield return new WaitForSeconds(10f);
        }
    }
}
