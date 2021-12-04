using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
            
            mcnt++;

        }
        if (mcnt == 5)
        {
            
            c1.SetActive(true);
            can.transform.position = new Vector3(1.3f, 1.5f, 0f);
            slider.value = 0;
            slider.transform.position = new Vector3(-0.8f,-3.2f,0f);

        }
        else if(mcnt == 10)
        {
            c2.SetActive(true);
            can.transform.position = new Vector3(8.4f, 1.5f, 0f);
            slider.value = 0;
            slider.transform.position = new Vector3(6.2f, -3.2f, 0f);
        }
        else if(mcnt == 15)
        {
            c3.SetActive(true);
        }
            
    }


    public void IncrementProgress(float newProg)
    {
        targetProgress = slider.value + newProg;
    }

    public void reset(GameObject go)
    {
        go.transform.Rotate(new Vector3(0f, 0f, 0f));
    }
}
