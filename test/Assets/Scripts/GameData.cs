using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData : MonoBehaviour
{
    public static GameData singleton;
    public string playerName;
    public int score = 0;

    private void Awake()
    {
        GameObject[] gd = GameObject.FindGameObjectsWithTag("gamedata");

        if (gd.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
        singleton = this;
    }


    public void SetName(string name)
    {
        playerName = name;
    }

    public void UpdateScore(int s)
    {
        score = s;
    }
}
