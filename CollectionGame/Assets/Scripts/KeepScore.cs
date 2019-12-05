using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class KeepScore : MonoBehaviour
{
    
    public static int Score = 0;
    private GUIStyle font;
    public void Start()
    {
        font = new GUIStyle();
        font.fontSize = 36;
    }
    private void OnGUI()
    {
            GUI.Box(new Rect(200, 200, 200, 200), Score.ToString(),font);
    }
}
