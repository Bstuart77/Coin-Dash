    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Timer : MonoBehaviour
{
    public static float timeLeft = 60.0f;
    public Text startText;

    private void Start()
    {

        KeepScore.Score = 0;
    }

    void Update()
    {
        timeLeft -= Time.deltaTime;
        startText.text = (timeLeft).ToString("0");
        if (timeLeft < 0.0)
        {
            SceneManager.LoadScene("EndGame");
            timeLeft = 60.0f;
        }
    }
}

