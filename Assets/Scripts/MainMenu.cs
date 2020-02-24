using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public void PlayGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Credits ()
    {
        SceneManager.LoadScene(2);
    }

    public void QuitGame ()
    {
        Debug.Log("OH SO YOU'RE LEAVING??? JUST LIKE MY DAD ON CHRISTMAS MORNING! FINE, I DONT EVEN CARE ANYWAYS!");
        Application.Quit();
    }
}
