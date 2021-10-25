using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
public class AUDIOSetting : MonoBehaviour
{
    public AudioMixer BgmMixer;
    
    public Slider BGMSlider;

    public void SetVolume(float volume)
    {
        BgmMixer.SetFloat("BgmVolume", volume);
    }

   

    private void Start()
    {
        BGMSlider.value = PlayerPrefs.GetFloat("BgmVolume",0);
       
    }

    private void OnDisable()
    {
        float BGMSistem = 0;
        


        BgmMixer.GetFloat("BgmVolume", out BGMSistem);
       
        PlayerPrefs.SetFloat("BgmVolume", BGMSistem);

        PlayerPrefs.Save();
    }
}
