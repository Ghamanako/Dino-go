using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BukaPanel : MonoBehaviour
{
    public GameObject panel, puzzle, PuzzleEZ, PuzzleHard, tutor,difficult;
    public GameObject awal, awal2;



    void Start()
    {
        Time.timeScale = 1;
    }

    public void Bukapanelll()
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

    public void PuzzleMulaiEz()
    {
        awal.SetActive(false);
        puzzle.SetActive(true);
        PuzzleEZ.SetActive(true);
        PuzzleHard.SetActive(false);
    }

    public void PuzzleMulaiHard()
    {
        awal2.SetActive(false);
        puzzle.SetActive(true);
        PuzzleEZ.SetActive(false);
        PuzzleHard.SetActive(true);
    }

    public void Easy()
    {
        awal.SetActive(true);
        difficult.SetActive(false);
    }

    public void Hard()
    {
        difficult.SetActive(false);
        awal2.SetActive(true);
    }
}
