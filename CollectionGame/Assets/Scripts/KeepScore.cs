using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepScore : MonoBehaviour
{
    public static int Score = 0;

    private void OnGUI()
    {
        
            GUI.Box(new Rect(100, 100, 100, 100), Score.ToString());
        
    }
}
