using System;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SliderSound : MonoBehaviour
{
    [SerializeField]
    private AudioMixer audioMixer;
    [SerializeField]
    private Slider slider;
    [SerializeField]
    private string audioMixerVolumeName;
    
    private float _volume;

    public void Awake()
    {
        audioMixer.GetFloat(audioMixerVolumeName, out _volume);
        
        slider.value = (float)Math.Pow(10, _volume / 20);
    }

    public void SetVolume(float sliderValue)
    {
        audioMixer.SetFloat(audioMixerVolumeName, (float)Math.Log10(sliderValue) * 20.0f);
    }
}
