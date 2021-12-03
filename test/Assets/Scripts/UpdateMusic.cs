using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateMusic : MonoBehaviour
{
    public AudioSource asource;


    // Start is called before the first frame update
    void Start()
    {
        //get music slider component
        Slider musicSlider = this.GetComponent<Slider>();
        
        //set starting value to 1. Slider value is between 0 and 1. Therefore 1 is full sound, 0 is mute
        musicSlider.value = 1;

        //Set intial sound
        UpdateMusicVolume(musicSlider.value);
    }

    //Update Music Volume everytime slider is updated.
    public void UpdateMusicVolume(float value)
    {
        PlayerPrefs.SetFloat("musicvolume", value);
        asource.volume = value;
    }
}
