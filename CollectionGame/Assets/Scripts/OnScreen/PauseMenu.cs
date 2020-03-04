using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool isPaused = false;
    public GameObject pauseMenuUI;
    public GameObject audioUI;

    private void Start()
    {
        pauseMenuUI.SetActive(false);
        audioUI.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                Resume();
           
            }
            else 
            {
                Pause();
            
            }
        }
    }
   public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }
   void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }
    public void showVolumeSlider()
    {
        pauseMenuUI.SetActive(false);
        audioUI.SetActive(true);
    }
    public void back()
    {
        pauseMenuUI.SetActive(true);
        audioUI.SetActive(false);
    }
    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Welcome");
        isPaused = false;
    }
    public void QuitGame()
    {
        Application.Quit();     
    }
    public void Resart()
    {
        SceneManager.LoadScene("Game");
        isPaused = false;
        KeepScore.Score = 0;
        Timer.timeLeft = 60f;
        Time.timeScale = 1f;
    }
}
