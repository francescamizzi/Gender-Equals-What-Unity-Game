using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ClickAndFill : MonoBehaviour
{
    public int mcnt = 0;
    public Slider slider;
    public Slider slider2;
    public Slider slider3;
    public GameObject can;
    public float fillspeed = 0.4f;
    private float targetProgress = 0;
    private float targetProgress2 = 0;
    private float targetProgress3 = 0;
    public int cnt = 0;
    public AudioSource source;
    public AudioClip clip;
    public GameObject c1;
    public GameObject c2;
    public GameObject c3;

    // Start is called before the first frame update
    void Start()
    {
        c1.SetActive(false);
        c2.SetActive(false);
        c3.SetActive(false);
        slider2.gameObject.SetActive(false);
        slider3.gameObject.SetActive(false);
        fill();
    }

    // Update is called once per frame
    void Update()
    {
        if (mcnt < 5)
        {
            if (slider.value < targetProgress)
            {
                slider.value += fillspeed * Time.deltaTime;
            }
        }
        else if (mcnt < 10 && mcnt >= 5)
        {
            if (slider2.value < targetProgress2)
            {
                slider2.value += fillspeed * Time.deltaTime;
            }
        }
        else if (mcnt <= 15 && mcnt >= 10)
        {
            if (slider3.value < targetProgress3)
            {
                slider3.value += fillspeed * Time.deltaTime;
            }
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
            IncrementProgress(0.2f, mcnt);
            mcnt++;

        }
        if (mcnt == 5)
        {

            c1.SetActive(true);
            can.transform.position = new Vector3(1.5f, 1.5f, 0f);
            slider.gameObject.SetActive(false);
            slider2.gameObject.SetActive(true);
            //slider.value = 0;
            //slider.transform.position = new Vector3(-77.5f, -376f, 0f);
            //starting -779, -376

        }
        else if (mcnt == 10)
        {
            c2.SetActive(true);
            can.transform.position = new Vector3(7f, 1.5f, 0f);
            slider2.gameObject.SetActive(false);
            slider3.gameObject.SetActive(true);
            /*slider.value = 0;
            slider.transform.position = new Vector3(665f, -379f, 0f);*/
        }
        else if (mcnt == 15)
        {
            c3.SetActive(true);
            nextScene();

        }

    }


    public void IncrementProgress(float newProg, int cnt)
    {
        if (cnt < 5)
        {
            targetProgress = slider.value + newProg;
        }
        else if (cnt < 10 && cnt >= 5)
        {
            targetProgress2 = slider2.value + newProg;
        }
        else if (cnt <= 15 && cnt >= 10)
        {
            targetProgress3 = slider3.value + newProg;
        }
    }

    public void nextScene()
    {
        SceneManager.UnloadSceneAsync("PlantWatering");
    }
}