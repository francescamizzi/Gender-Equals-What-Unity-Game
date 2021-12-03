using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menuscript : MonoBehaviour
{
    GameObject optionsPanel;
    GameObject namePanel;

    //We start with the namePanel already active. FindGameObjectWithTag() returns null if the game object is deactivated. 
    //The options panel is set as active from Unity, and then we set it immediately to deactivated from the code. 
    private void Start()
    {
        optionsPanel = GameObject.FindGameObjectWithTag("optionsPanel");

        if (optionsPanel != null)
        {
            optionsPanel.SetActive(false);
        }

        namePanel = GameObject.FindGameObjectWithTag("namePanel");
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Minigame");
    }

    public void OpenOptionsPanel()
    {
        optionsPanel.SetActive(true);
    }

    public void CloseOptionsPanel()
    {
        optionsPanel.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void CloseNamePanel()
    {
        namePanel.SetActive(false);
    }
}
