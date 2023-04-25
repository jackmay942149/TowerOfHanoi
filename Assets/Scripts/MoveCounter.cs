using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoveCounter : MonoBehaviour
{
    public int count = 0;
    public TextMeshProUGUI textMesh;

    public void AddMove()
    {
        count++;
        UpdateText();
    }

    public void UpdateText()
    {
        textMesh.text = "Move Counter: " + count.ToString();
    }
}
