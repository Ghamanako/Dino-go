using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bukaPanel : MonoBehaviour
{
    public GameObject panel, Next, Back;
   
    
    public void BukaPanel()
    {
        panel.gameObject.SetActive(true);
    }

    public void TutupPanel()
    {
        panel.gameObject.SetActive(false);
    }

    public void TutorialPanel()
    {
        panel.SetActive(true);
    }

    public void nextPanel()
    {
        Next.SetActive(true);
        Back.SetActive(false);
    }
    public void BAckPanel()
    {
        Next.SetActive(false);
        Back.SetActive(true);
    }

}
