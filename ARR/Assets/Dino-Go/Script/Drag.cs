using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
    public GameObject detector;
    Vector3 posisi_awal,Scale_awal;
    bool on_pos = false;


    void Start()
    {
        posisi_awal = transform.position;
        Scale_awal = transform.localScale;
    }

    void OnMouseDrag()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, -Camera.main.transform.position.z + transform.position.z);
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = objPosition;
        transform.localScale = new Vector2(1.5f, 1.5f);
       
    }

    void OnMouseUp()
    {
        if (on_pos)
        {
            transform.position = detector.transform.position;
            transform.localScale = new Vector2(1.5f, 1.5f);
        }
        else
        {
            transform.position = posisi_awal;
            transform.localScale = Scale_awal;
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject == detector)
        {
            on_pos = true;
        }   
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject == detector)
        {
            on_pos = false;
        }   
    }
}
