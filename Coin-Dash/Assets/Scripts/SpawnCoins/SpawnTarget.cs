using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTarget : MonoBehaviour
{
    public GameObject enemy;
    private int xPos;
    private int zPos;

    void Start()
    {
       StartCoroutine(spawnTarget());
    }

    IEnumerator spawnTarget()
    {
        while(Timer.timeLeft > 0)
        {
            xPos = Random.Range(-20, 20);
            zPos = Random.Range(-20, 20);
            Instantiate(enemy, new Vector3(xPos, 1.6f, zPos),enemy.transform.rotation);

            yield return new WaitForSeconds(3f);
        }
    }
}
