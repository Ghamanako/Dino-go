using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSFX : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip clickSFX;
  

    public void ClickSound()
    {
        if (audioSource != null)
        {
            audioSource.PlayOneShot(clickSFX);
        }
    }

    public void ExitGame()
    {
        if (Input.backButtonLeavesApp)
        {
            Application.Quit();
        }
    }
}
