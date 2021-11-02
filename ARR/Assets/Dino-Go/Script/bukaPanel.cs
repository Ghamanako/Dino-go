using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bukaPanel : MonoBehaviour
{
    public GameObject panel, Next, Back, puzzle, tutor;
    public GameObject awal;
    public Animator animator;


    void Start()
    {
        animator = panel.GetComponent<Animator>();   
    }

    public void BukaPanel()
    {
        panel.gameObject.SetActive(true);
        animator.SetTrigger("open");
    }

    public void TutupPanel()
    {
        animator.SetTrigger("close");
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

    public void BukaTutor()
    {
        puzzle.SetActive(false);
        tutor.SetActive(true);
    }

    public void TutupTutor()
    {
        tutor.SetActive(false);
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
