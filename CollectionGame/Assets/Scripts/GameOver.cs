    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameOver : MonoBehaviour
{
    public float timeLeft = 60.0f;
    public Text startText; 


    void Update()
    {
        timeLeft -= Time.deltaTime;
        startText.text = (timeLeft).ToString("0");
        if (timeLeft < 0)
        {
            //fix to make it transfer to another screen/leaderboard
            Destroy(gameObject);
        }
    }
}
