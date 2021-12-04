//Description
// This is the class for making the bed. It allows the user to
// to pick up the blanket and make the bed in the 'make bed' minigame. 
#pragma strict

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class makeBed : MonoBehaviour
{
    public AudioSource audio;
    public AudioClip audioClip;
    public int mouseClicks = 0;
    public bool success = false;
    public GameObject check;
    public GameObject nextButton;

    public itemsAppear items;

    void Start()
    {
        check.SetActive(false);
        nextButton.SetActive(false);
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
            {
                mouseClicks++;
            }

        if(mouseClicks >= 10)
        {

            gameObject.SetActive(false);
            audio.PlayOneShot(audioClip);
            success = true;

            check.SetActive(true);
            nextButton.SetActive(true);
            //SceneManager.UnloadSceneAsync("makebed");
        }

        if(!gameObject.activeSelf){
            print("Bed made successfully!");
            print("Mouse Clicks: " + mouseClicks);
        }
    
    }

    public void nextScene()
    {
        SceneManager.UnloadSceneAsync("makebed");
        items = GameObject.FindObjectOfType(typeof(itemsAppear)) as itemsAppear;
        items.blanketAppears(success);
    }

}