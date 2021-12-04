//Description
// This is the class for picking up the collectibles. It allows the user to
// to pick up the items on the floor in the 'clean room' minigame. 
#pragma strict

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class pickupItems : MonoBehaviour
{
    public AudioSource audio;
    public AudioClip audioClip;
    private int counter = 0;
    public bool success = false;

    void OnMouseDown(){
        gameObject.SetActive(false);
        audio.PlayOneShot(audioClip);
        counter++;

        if (counter == 5)
        {
            gameObject.SetActive(false);
            audio.PlayOneShot(audioClip);
            success = true;
        }

        if (!gameObject.activeSelf)
        {
            print("Clothes picked up successfully!");
            print("counter: " + counter);
        }
    }
        void Update()
    {
        if (counter == 5)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);        
        }    
    }
}

/*
    public void nextScene()
    {
        SceneManager.UnloadSceneAsync("makebed");
        items = GameObject.FindObjectOfType(typeof(itemsAppear)) as itemsAppear;
        items.blanketAppears(success);
    }
*/