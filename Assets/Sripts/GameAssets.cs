using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameAssets : MonoBehaviour
{
    public static GameAssets instance;

    public Sprite snakeHeadSprite;
    public Sprite snakeBodySprite;
    public Sprite foodSprite;

    public SoundAudioClip[] soundAudioClipsArray;

    public void Awake()
    {
        instance = this;
    }

    [Serializable]
    public class SoundAudioClip 
    {
        public SoundManager.Sound sound;
        public AudioClip audioClip;
    }
}
