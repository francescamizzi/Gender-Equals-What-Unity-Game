using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroMenu : MonoBehaviour
{
    public void startGame()
    {
        Debug.Log("Starting Game");

        // Starting game
        SceneManager.LoadScene("BedroomStart");
    }

    public void loadHelp()
    {
        Debug.Log("Loading Help");

        // redirecting to help scene
        SceneManager.LoadScene("Instructions");

    }

    public void quitGame()
    {
        Debug.Log("Quitting Game");
        
        // closing application
        Application.Quit();
    }
}
