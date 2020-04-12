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
        musicSlider.value = PlayerPrefs.GetFloat("MusicVolume", 1f);
    }
    void Update()
    {
        music.volume = musicSlider.value;
    }

    public void volumePrefs()
    {
        PlayerPrefs.SetFloat("MusicVolume", music.volume);
    }

    
}
