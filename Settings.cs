using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Settings : MonoBehaviour
{
    public GameObject alarmSound;
    public AudioMixer master;

    // Update is called once per frame
    
    public void setSFXVolume(float volume)
    {
        master.SetFloat("sfxVolume", volume);
    }

    public void setMusicVolume(float volume)
    {
        master.SetFloat("musicVolume", volume);
    }

    public void setFullscreen(bool isFull)
    {
        Screen.fullScreen = isFull;
    }

    public void noAlarm(bool noAlarm)
    {
        alarmSound.SetActive(noAlarm);
    }
}
