using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
    public bool isDragable = true;
    public bool isDragged = false;

    void Update()
    {
     if(isDragged)
        {
            transform.position = (Vector3) Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
    }

    private void OnMouseOver()
    {
        if (isDragable && Input.GetMouseButtonDown(0))
        {
            isDragged = true;
        }
    }

    private void OnMouseUp()
    {
        isDragged = false;
    }
}
