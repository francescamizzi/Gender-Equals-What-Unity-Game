using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroMenu : MonoBehaviour
{
    public void start()
    {
        Debug.Log("Starting Game");

        // Starting game
        SceneManager.LoadScene("Fran Test");
    }

    public void loadHelp()
    {
        Debug.Log("Loading Help");

        // redirecting to help scene
        //SceneManager.LoadScene("");

    }

    public void quit()
    {
        Debug.Log("Quitting Game");
        
        // closing application
        //Application.Quit();
    }
}
