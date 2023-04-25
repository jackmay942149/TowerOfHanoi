using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pole : MonoBehaviour
{
    public List<Ring> ringList;

    public void AddRing(Ring ring)
    {
        ringList.Add(ring);
    }

    public void RemoveRing(Ring ring)
    {
        ringList.Remove(ring);
    }

    public bool CheckIfTop(Ring ring)
    {
        if (ringList[ringList.Count - 1] == ring)
        {
            return true;
        }
        return false;
    }

    public float GetHeight()
    {
        float height = -2.25f + ringList.Count * 0.5f;
        return height;
    }

    public bool CheckSize(Ring ring)
    {
        if (ringList.Count == 0)
        {
            return true;
        }
        else if (ring.ringSize > ringList[ringList.Count - 1].ringSize)
        {
            return false;
        }
        return true;
    }
}
