using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class KeepScore : MonoBehaviour
{
    public Text scoreText;
    public static int Score = 0;
 
    private void Update()
    {
        scoreText.text = Score.ToString();
    }
}
