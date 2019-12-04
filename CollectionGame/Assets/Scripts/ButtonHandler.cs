using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ButtonHandler : MonoBehaviour
{
    public void OnMouseUp()
    {
        SceneManager.LoadScene("Game");
    }
}
