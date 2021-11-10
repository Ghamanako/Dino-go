using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bukaPanel : MonoBehaviour
{
    public GameObject panel,puzzle, tutor;
    public GameObject awal;
   


    void Start()
    {
         
    }

    public void BukaPanel()
    {
        panel.gameObject.SetActive(true);
       
    }

    public void TutupPanel()
    {
       
        
    }

    public void TutorialPanel()
    {
        panel.SetActive(true);
    }

  

    public void BukaTutor()
    {
        puzzle.SetActive(false);
      
    }

    public void TutupTutor()
    {
       
        puzzle.SetActive(true);
    }

    public void TUtorAr()
    {
        tutor.SetActive(true);
    }

    public void CloseAr()
    {
        tutor.SetActive(false);
    }

    public void Puzzle2Mulai()
    {
        awal.SetActive(false);
        puzzle.SetActive(true);
    }
}
