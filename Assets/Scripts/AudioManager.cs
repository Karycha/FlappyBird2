using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioManager : Singleton<AudioManager>
{

    public AudioSource wing, point, dead, button, soundtrack;
    public AudioMixer mixer;
    public Slider musicSlider, sfxSlider;
   

    private const string MIXER_MUSIC = "MusicVolume";
    private const string MIXER_SFX = "SFXVolume";

    public override void Awake()
    {
        base.Awake();
        musicSlider.onValueChanged.AddListener(SetMusicVolume);
        sfxSlider.onValueChanged.AddListener(SetSFXVolume);
    }

    private void SetMusicVolume(float value)
    {
        mixer.SetFloat(MIXER_MUSIC, Mathf.Log(value)*20);
    }

    private void SetSFXVolume(float value)
    {
        mixer.SetFloat(MIXER_SFX, Mathf.Log(value) * 20);
    }


    public void PlayWing()
    { 
        wing.Play(); 
    }
    public void PlayPoint()
    {
        point.Play();
    }
    public void PlayDead() 
    { 
        dead.Play();
    }
    public void PlayButton() 
    {
        button.Play(); 
    }

}
