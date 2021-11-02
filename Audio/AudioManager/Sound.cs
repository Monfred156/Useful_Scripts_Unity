using UnityEngine;
using UnityEngine.Audio;

[System.Serializable]
public class Sound
{
    public EnumSounds name;
    public AudioClip audioClip;

    [Range(0f, 1f)]
    public float volume;
    [Range(.1f, 3f)]
    public float pitch;
    public bool loop;
    public bool playOnAwake;

    public AudioMixerGroup audioMixerGroup;

    [HideInInspector]
    public AudioSource audioSource;
}