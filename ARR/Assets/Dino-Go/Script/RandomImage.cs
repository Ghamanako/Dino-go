using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RandomImage : MonoBehaviour
{
    void Start()
    {
        Random_Tombol();   
    }

    public void Random_Tombol()
    {
        Vector3[] pos_Tombol = new Vector3[transform.childCount];
        bool[] terpasang = new bool[transform.childCount];

        for (int i = 0; i < pos_Tombol.Length; i++)
        {
            pos_Tombol[i] = transform.GetChild(i).transform.position;
            terpasang[i] = false;
        }

        for (int i = 0; i < pos_Tombol.Length; i++)
        {
            bool mengulang = true;
            while (mengulang)
            {
                int pos_random = Random.Range(0, transform.childCount);
                if (!terpasang[pos_random])
                {
                    transform.GetChild(i).transform.position = pos_Tombol[pos_random];
                    terpasang[pos_random] = true;
                    mengulang = false;
                }
                else
                {
                    mengulang = true;
                }
            }
           
        }
    }
}
