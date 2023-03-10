using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource musicAudio;

    public AudioSource[] sfxAudio;


    public void Awake()
    {

    }

    public void Start()
    {
    }

    void GameStart()
    {

    }


    public void OnSwitchMusic(bool check)
    {
        if (check)
        {
            musicAudio.volume = 1;

            musicAudio.Stop();
            musicAudio.Play();
        }
        else
        {
            musicAudio.volume = 0;
        }
    }

    public void OnSwitchSFX(bool check)
    {
        if (check)
        {
            for (int i = 0; i < sfxAudio.Length; i++)
            {
                sfxAudio[i].volume = 1;
                sfxAudio[1].volume = 0.5f;
            }
        }
        else
        {
            for (int i = 0; i < sfxAudio.Length; i++)
            {
                sfxAudio[i].volume = 0;
            }
        }
    }

    public void StopBGM()
    {
        musicAudio.Stop();
    }

    public void PlaySFX(GameSfxType type)
    {
        for (int i = 0; i < sfxAudio.Length; i++)
        {
            if (sfxAudio[i].name.Equals(type.ToString()))
            {
                if (!sfxAudio[i].isPlaying) sfxAudio[i].Play();
            }
        }
    }


    public void HighTimer()
    {
        musicAudio.pitch = 1;
    }
    public void LowTimer()
    {
        if (musicAudio.pitch != 1.05f)
        {
            musicAudio.pitch = 1.05f;
        }
    }

}