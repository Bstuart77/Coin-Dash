    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Timer : MonoBehaviour
{
    public static float timeLeft = 5.0f;
    public Text startText;


    void Update()
    {
        timeLeft -= Time.deltaTime;
        startText.text = (timeLeft).ToString("0");
        if (timeLeft < 0.0)
        {
            SceneManager.LoadScene("LeaderBoard");
            timeLeft = 60.0f;
        }
    }
}

