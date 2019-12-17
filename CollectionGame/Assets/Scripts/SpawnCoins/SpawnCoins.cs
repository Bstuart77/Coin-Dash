using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCoins : MonoBehaviour
{
    
    public GameObject theEnemy;
    public int xPos;
    public int zPos;



    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CoinSpawn());
    }

    IEnumerator CoinSpawn()
    {
        while (Timer.timeLeft > 0)
        {
            xPos = Random.Range(-20, 20);
            zPos = Random.Range(-20, 20);
            Instantiate(theEnemy, new Vector3(xPos, 1.61f, zPos), Quaternion.identity);

            yield return new WaitForSeconds(1.5f);
        }
    }
}
