using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenResolution : MonoBehaviour
{
    private CanvasScaler canvasScaler;

    private void Awake()
    {
        canvasScaler = GetComponent<CanvasScaler>();
    }

    // Start is called before the first frame update
    void Start()
    {
        float screenHeight = Screen.height;
        float screenWidth = Screen.width;
        float ScaleFactor = screenHeight / screenWidth;
        float standardFactor = 16f / 9f;
        if (ScaleFactor < standardFactor)
        {
            canvasScaler.matchWidthOrHeight = 1;
        }
        else
        {
            canvasScaler.matchWidthOrHeight = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
