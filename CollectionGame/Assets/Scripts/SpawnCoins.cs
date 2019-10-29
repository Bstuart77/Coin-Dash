using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCoins : MonoBehaviour
{
       public GameObject theEnemy;
    public int xPos;
    public int zPos;
    public int coinCount;



    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CoinSpawn());  
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Player")
        {
            other.GetComponent<Movement>().points++;
            Destroy(gameObject);
        }
        
    }
  
    IEnumerator CoinSpawn()
    {
        while (coinCount < 10)
        {
            xPos = Random.Range(-20, 20);
            zPos = Random.Range(-20, 20);
            Instantiate(theEnemy, new Vector3(xPos,1.61f,zPos), Quaternion.identity);

            yield return new WaitForSeconds(0.1f);
            coinCount += 1;
        }
    }
}
