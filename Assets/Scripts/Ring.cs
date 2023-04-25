using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Ring : MonoBehaviour
{
    public Pole poleL;
    public Pole poleC;
    public Pole poleR;
    public Pole currentPole;
    public float ringSize;
    public Vector3 position;

    void Awake()
    {
        position = this.transform.position;
        ringSize = this.transform.localScale.x;
    }

    void OnMouseDrag()
    {
        if (currentPole.CheckIfTop(this))
        {
            transform.position = GetMousePos();
        }
        
    }

    void OnMouseUp()
    {
        Vector3 mousePos = GetMousePos();

        if (currentPole.CheckIfTop(this))
        {
            if (mousePos.x <= -2.5f && poleL.CheckSize(this))
            {
                transform.position = SetRing();
            }
            else if (mousePos.x >= 2.5f && poleR.CheckSize(this))
            {
                transform.position = SetRing();
            }
            else if (mousePos.x > -2.5f && mousePos.x < 2.5f && poleC.CheckSize(this))
            {
                transform.position = SetRing();
            }
            else
            {
                transform.position = position;
            }
            position = this.transform.position;          
        }
    }
    
    Vector3 GetMousePos()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        return mousePos;
    }

    Vector3 SetRing()
    {
        Vector3 ringPos = GetMousePos();
        currentPole.RemoveRing(this);
        if (ringPos.x <= -2.5f)
        {
            ringPos.x = -5f;
            poleL.AddRing(this);
            currentPole = poleL;
        }
        else if (ringPos.x >= 2.5f)
        {
            ringPos.x = 5f;
            poleR.AddRing(this);
            currentPole = poleR;
        }
        else
        {
            ringPos.x = 0f;
            poleC.AddRing(this);
            currentPole = poleC;
        }
        ringPos.y = currentPole.GetHeight();
        return ringPos;
    }
}
