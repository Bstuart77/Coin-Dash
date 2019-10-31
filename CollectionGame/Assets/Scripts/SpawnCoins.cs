using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCoins : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject theEnemy;
    public int xPos;
    public int zPos;
    public int coinCount = 0;



    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(RedCoinSpawn());
    }

    IEnumerator RedCoinSpawn()
    {
        while (coinCount < 10)
        {
            xPos = Random.Range(-20, 20);
            zPos = Random.Range(-20, 20);
            Instantiate(theEnemy, new Vector3(xPos, 1.61f, zPos), Quaternion.identity);

            yield return new WaitForSeconds(1.5f);
            coinCount++;
        }
    }
}
