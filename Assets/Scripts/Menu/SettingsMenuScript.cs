using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsMenuScript : MonoBehaviour
{
    public AudioSource audioSrc;
    public Slider volumeSlider;
    private float musicVolume;
    private float firstStartVolumeValue = 0.5f;

    void Start()
    {
        if (PlayerPrefs.HasKey("volumeValue"))
        {
            musicVolume = PlayerPrefs.GetFloat("volumeValue");
        }
        else 
        {
            PlayerPrefs.SetFloat("volumeValue", firstStartVolumeValue);
            musicVolume = firstStartVolumeValue;
        }

        volumeSlider.value = musicVolume;
    }

    void Update()
    {
        musicVolume = volumeSlider.value;
        audioSrc.volume = volumeSlider.value;
        PlayerPrefs.SetFloat("volumeValue", volumeSlider.value);
    }
}
