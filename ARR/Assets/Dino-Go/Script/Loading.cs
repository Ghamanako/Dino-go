using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour
{
    public float time;
    public Slider slider;

    private void Start()
    {
        slider.value = 0;
        slider.maxValue = time;
    }

    private void Update()
    {
        if (slider.value < slider.maxValue)
        {
            slider.value += Time.deltaTime;
        }
        if (slider.value == slider.maxValue)
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}