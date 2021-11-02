using System;
using System.Security.Cryptography;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;

    public static AudioManager instance;

    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);

        foreach (var sound in sounds)
        {
            sound.audioSource = gameObject.AddComponent<AudioSource>();
            sound.audioSource.clip = sound.audioClip;
            sound.audioSource.volume = sound.volume;
            sound.audioSource.pitch = sound.pitch;
            sound.audioSource.loop = sound.loop;
            sound.audioSource.playOnAwake = sound.playOnAwake;
            sound.audioSource.outputAudioMixerGroup = sound.audioMixerGroup;
        }
    }

    private void Start()
    {
        Play(EnumSounds.MainMenu);
    }

    public void Play(EnumSounds name)
    {
        Sound sound = Array.Find(sounds, sound => sound.name == name);
        if (!sound.audioSource.isPlaying)
        {
            sound.audioSource.Play();
        }
    }

    public void Play(string name)
    {
        Sound sound = Array.Find(sounds, sound => sound.name.ToString() == name);
        if (!sound.audioSource.isPlaying)
        {
            sound.audioSource.Play();
        }
    }

    public void StopAllSounds()
    {
        foreach (var sound in sounds)
        {
            if (sound.audioSource.isPlaying)
            {
                sound.audioSource.Stop();
            }
        }
    }
}