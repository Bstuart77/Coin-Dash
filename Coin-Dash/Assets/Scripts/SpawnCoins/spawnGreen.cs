using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnGreen : MonoBehaviour
{
    public GameObject theEnemy;
    private int xPos;
    private int zPos;



    void Start()
    {
        StartCoroutine(GreenCoinSpawn());
    }

    IEnumerator GreenCoinSpawn()
    {
        while (Timer.timeLeft > 0)
        {
            xPos = Random.Range(-20, 20);
            zPos = Random.Range(-20, 20);
            Instantiate(theEnemy, new Vector3(xPos, 1.61f, zPos), Quaternion.identity);

            yield return new WaitForSeconds(3.5f);
        }
    }
}
