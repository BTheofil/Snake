using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CodeMonkey.Utils;

public static class SoundManager
{
    public enum Sound 
    {
        SnakeMove,
        SnakeDie,
        SnakeEat,
        ButtonClick,
        ButtonOver,
    }

    public static void PlaySound(Sound sound) 
    {
        GameObject soundGameObject = new GameObject("Sound");
        AudioSource audioSource = soundGameObject.AddComponent<AudioSource>();
        audioSource.PlayOneShot(GetAudioClip(sound));       
    }

    private static AudioClip GetAudioClip(Sound sound) 
    {
        foreach (GameAssets.SoundAudioClip soundAudioClip in GameAssets.instance.soundAudioClipsArray) 
        {
            if (soundAudioClip.sound == sound) 
            {
                return soundAudioClip.audioClip;
            }
        }
        return null;
    }
}
