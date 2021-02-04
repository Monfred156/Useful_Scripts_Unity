using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;

public class UIOptions : MonoBehaviour
{
    public AudioMixer audioMixer;
    public Slider masterVolumeSlider;
    public Slider musicVolumeSlider;
    public Slider fxVolumeSlider;

    private float _masterVolume; 
    private float _musicVolume;
    private float _fxVolume;
    
    public void Awake()
    {
        audioMixer.GetFloat("MasterVolume", out _masterVolume);
        audioMixer.GetFloat("MusicVolume", out _musicVolume);
        audioMixer.GetFloat("FXVolume", out _fxVolume);
        
        masterVolumeSlider.value = (float)Math.Pow(10, _masterVolume / 20);
        musicVolumeSlider.value = (float)Math.Pow(10, _musicVolume / 20);
        fxVolumeSlider.value = (float)Math.Pow(10, _fxVolume / 20);
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void SetMasterVolume(float sliderValue)
    {
        audioMixer.SetFloat("MasterVolume", (float)Math.Log10(sliderValue) * 20.0f);
    }

    public void SetMusicVolume(float sliderValue)
    {
        audioMixer.SetFloat("MusicVolume", (float)Math.Log10(sliderValue) * 20.0f);
    }
    
    public void SetFXVolume(float sliderValue)
    {
        audioMixer.SetFloat("FXVolume", (float)Math.Log10(sliderValue) * 20.0f);
    }
}