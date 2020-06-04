﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

   
    [SerializeField]
    private AudioSource backgroundMusic, deathSound, scoreSound, havocSound;

    [HideInInspector]
    public bool soundIsOn = true;        
    

    public void StopBackgroundMusic()
    {
        backgroundMusic.Stop();
    }

    public void PlayBackgroundMusic()
    {
        if (soundIsOn)
            backgroundMusic.Play();
    }

    public void ScoreSound()
    {
        if (soundIsOn)
            scoreSound.Play();
    }

    public void DeathSound()
    {
        if (soundIsOn)
            deathSound.Play();
    }

    public void HavocSound()
    {
        if (soundIsOn)
            havocSound.Play();
    }
}