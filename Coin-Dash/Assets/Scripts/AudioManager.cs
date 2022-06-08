using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public AudioSource music;
    public Slider musicSlider;


    private void Start()
    {
        if(PlayerPrefs.GetFloat("volume") == 0f)
        {
            music.volume = 0.3f;
        }

        music.volume = PlayerPrefs.GetFloat("volume");
        musicSlider.value = music.volume;

    }


    public void MasterVolume(float mastVolume)
    {
        music.volume = mastVolume;
        PlayerPrefs.SetFloat("volume", music.volume);
        PlayerPrefs.Save();
    }


}
