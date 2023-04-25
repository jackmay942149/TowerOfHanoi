using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCondition : MonoBehaviour
{
    public Pole poleL;
    public Pole poleC;
    public GameObject endCanvas;

    void Update()
    {
        if (HasWon())
        {
            endCanvas.SetActive(true);
            Camera.main.backgroundColor = new Color(0.0f, 1.0f, 0.0f, 1.0f);
        }
    }

    public bool HasWon()
    {
        if (poleL.ringList.Count != 0)
        {
            return false;
        }
        else if (poleC.ringList.Count !=0)
        {
            return false;
        }
        return true;
    }

    public void Continue()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.buildIndex + 1);
    }
    
    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
