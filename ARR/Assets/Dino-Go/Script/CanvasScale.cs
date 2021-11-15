using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasScale : MonoBehaviour
{
    public float ResoX;
    public float ResoY;

    private CanvasScaler can;
    // Start is called before the first frame update
    void Start()
    {
        can = GetComponent<CanvasScaler>();
        SetInfo();
    }

    void SetInfo()
    {
        ResoX = (float)Screen.currentResolution.width;
        ResoY = (float)Screen.currentResolution.height;

        can.referenceResolution = new Vector2(ResoX, ResoY);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
