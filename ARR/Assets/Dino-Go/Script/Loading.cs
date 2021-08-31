using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour
{
    public Slider slider;

    private void Update()
    {
        if (slider.value < slider.maxValue)
        {
            slider.value += Time.deltaTime;
        }
        if (slider.value == slider.maxValue)
        {
            SceneManager.LoadScene("Matching Card Proto");
        }
    }
}