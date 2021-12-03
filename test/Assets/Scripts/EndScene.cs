///Description;
/// This is the class for the player controller. It controls the behaviour of the ball 
/// in the MiniGame scene.  
///

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndScene : MonoBehaviour
{
    public Text nameText;
    public Text scoreText;
    GameData gameData;

    GameData[] gameDataList;

    private void Start()
    {
        //We retrieve the GameData component of the GameManager game object holding the player name and score.
        gameData = GameObject.FindGameObjectWithTag("gamedata").GetComponent<GameData>();

        //Populate the text elements of NameText and ScoreText with values from the singleton class.
        nameText.text = gameData.playerName;
        scoreText.text = gameData.score.ToString();
    }

    public void restart()
    {
        SceneManager.LoadScene("Minigame");
    }

    public void exitGame()
    {
        Application.Quit();
    }

    public void backToMenu()
    {
        //Destroy game data and all relevant player data
        GameObject[] gd = GameObject.FindGameObjectsWithTag("gamedata");

        foreach (GameObject gdo in gd)
        {
            Destroy(gdo);
        }

        SceneManager.LoadScene("Menuscene");
    }
}
