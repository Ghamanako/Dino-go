using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
public class AUDIOSetting : MonoBehaviour
{
    public AudioMixer BgmMixer, SFXMixer;

    public Slider BGMSlider, SfxSlider;

    public void SetVolume(float volume)
    {
        BgmMixer.SetFloat("BgmVolume", volume);
    }

    public void SetSFXVolume(float SVolume)
    {
        SFXMixer.SetFloat("SFXVolume", SVolume);
    }

   

    private void Start()
    {
        BGMSlider.value = PlayerPrefs.GetFloat("BgmVolume",0);
        SfxSlider.value = PlayerPrefs.GetFloat("SFXVolume", 0);
    }

    private void OnDisable()
    {
        float BGMSistem = 0;
        float SFXSistem = 0;


        BgmMixer.GetFloat("BgmVolume", out BGMSistem);

        SFXMixer.GetFloat("SFXVolume", out SFXSistem);

        PlayerPrefs.SetFloat("BgmVolume", BGMSistem);

        PlayerPrefs.SetFloat("SFXVolume", SFXSistem);

        PlayerPrefs.Save();
    }
}
