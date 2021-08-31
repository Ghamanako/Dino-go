using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class entah : MonoBehaviour
{
    public CardGameManager lol;
    public float loll;
    private bool gameStart;
    public int jumlahKartu;

    private void Start()
    {
        lol.SetGameSize(jumlahKartu);
    }

    private void Update()
    {
        if (!gameStart)
        {
            loll -= Time.deltaTime;
        }
        if (loll <= 0)
        {
            gameStart = true;
            lol.StartCardGame();
        }
    }
}