using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public void PlayGame()
    {
        DataHolder.Sex = 4;
        SceneManager.LoadScene(0);
    }

    public void PlayGame2Players()
    {
        DataHolder.Sex = 2;
        SceneManager.LoadScene(0);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void OpenMenu()
    {
        Debug.Log("sex");
        SceneManager.LoadScene(2);
    }

}
