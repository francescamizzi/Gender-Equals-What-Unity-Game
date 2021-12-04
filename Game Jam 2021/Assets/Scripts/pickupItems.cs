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
    public GameObject check;
    public GameObject nextButton;

    public itemsAppear items;

    void Start()
    {
        check.SetActive(false);
        nextButton.SetActive(false);
    }

    void OnMouseDown(){
        gameObject.SetActive(false);
        audio.PlayOneShot(audioClip);
        counter = counter + 1;

        if (counter >= 6)
        {
            gameObject.SetActive(false);
            audio.PlayOneShot(audioClip);
            success = true;

            check.SetActive(true);
            nextButton.SetActive(true);
        }

            if (!gameObject.activeSelf){
            print("Clothes picked up successfully!");
            print("counter: " + counter);
        }
    }

    public void nextScene()
    {
        SceneManager.UnloadSceneAsync("cleanroom");
        items = GameObject.FindObjectOfType(typeof(itemsAppear)) as itemsAppear;
        items.clothesDisappear(success);
    }
}