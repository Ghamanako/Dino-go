using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
    public string posisi = "";
    public GameObject detector;
    Vector3 posisi_awal,Scale_awal;
    bool on_pos = false;
    public AudioSource audioSource;
    public AudioClip benar, salah;
    public Transform effect;

    void Start()
    {
        posisi_awal = transform.position;
        Scale_awal = transform.localScale;
      
    }

    void Update()
    {
       
       
    }

    void OnMouseDrag()
    {

        if (posisi != "locked")
        {
            Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, -Camera.main.transform.position.z + transform.position.z);
            Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.position = objPosition;
        }

    }

    void OnMouseUp()
    {
        if (on_pos)
        {
            transform.position = detector.transform.position;
            audioSource.PlayOneShot(benar);
            posisi = "locked";
            Instantiate(effect, gameObject.transform.position, effect.rotation);
           
        }
        else
        {
            transform.position = posisi_awal;
            transform.localScale = Scale_awal;
            audioSource.PlayOneShot(salah);
        }
    }
    
    void OnTriggerEnter(Collider other)
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
