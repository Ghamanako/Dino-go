﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSFX : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip clickSFX;
  

    public void ClickSound()
    {
        audioSource.PlayOneShot(clickSFX);
    }
}