using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Instructions : MonoBehaviour
{
    public void returnIntro()
    {
        Debug.Log("Returning to Intro Screen");

        // Starting game
        SceneManager.LoadScene("IntroMenu");
    }
}
