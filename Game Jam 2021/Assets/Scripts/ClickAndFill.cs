using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ClickAndFill : MonoBehaviour
{
    public int mcnt = 0;
    public Slider slider;
    public GameObject can;
    public float fillspeed = 0.4f;
    private float targetProgress = 0;
    public int cnt = 0;
    public AudioSource source;
    public AudioClip clip;
    public GameObject c1;
    public GameObject c2;
    public GameObject c3;
    public float rotateSpeed = 8f;

    // Start is called before the first frame update
    void Start()
    {
        c1.SetActive(false);
        c2.SetActive(false);
        c3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (slider.value < targetProgress)
        {
            slider.value += fillspeed * Time.deltaTime;
        }

        if (cnt == 0)
        {
            fill();
        }
        
        
    }

    public void fill()
    {
        if (Input.GetMouseButtonDown(0))
        {
            source.PlayOneShot(clip);
            IncrementProgress(0.2f);
            can.active = true;
            mcnt++;

        }
        if (mcnt == 5)
        {
            c1.SetActive(true);
            can.active = true;
            can.transform.position = new Vector3(1f, 108.7f, 0f);
            slider.value = 0;
            slider.transform.position = new Vector3(-22f, -140f, 0f);

        }
        else if(mcnt == 10)
        {
            c2.SetActive(true);
            can.active = true;
            can.transform.position = new Vector3(7f, 108.7f, 0f);
            slider.value = 0;
            slider.transform.position = new Vector3(227f, -140f, 0f);

        }
        else if(mcnt == 15)
        {
            c3.SetActive(true);
            nextScene();

        }
            
    }


    public void IncrementProgress(float newProg)
    {
        targetProgress = slider.value + newProg;
    }

    public void nextScene()
    {
        SceneManager.UnloadSceneAsync("PlantWatering");
    }
}
