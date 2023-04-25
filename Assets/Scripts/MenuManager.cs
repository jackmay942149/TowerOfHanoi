using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void Easy()
    {
        SceneManager.LoadScene(1);
    }
    public void Medium()
    {
        SceneManager.LoadScene(2);
    }
    public void Hard()
    {
        SceneManager.LoadScene(3);
    }
    public void Insane()
    {
        SceneManager.LoadScene(4);
    }
    public void Rules()
    {
        SceneManager.LoadScene("Rules");
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void Menu()
    {
        SceneManager.LoadScene("Menu0");
    }

}
