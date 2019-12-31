using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayButton : MonoBehaviour
{
    public void OnMouseUp()
    {
        SceneManager.LoadScene("Game");
        KeepScore.Score = 0;

    }

}
