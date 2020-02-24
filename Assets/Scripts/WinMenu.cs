using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour
{
    public void Retry()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Debug.Log("OH SO YOU'RE LEAVING??? JUST LIKE MY DAD ON CHRISTMAS MORNING! FINE, I DONT EVEN CARE ANYWAYS!");
        Application.Quit();
    }
}