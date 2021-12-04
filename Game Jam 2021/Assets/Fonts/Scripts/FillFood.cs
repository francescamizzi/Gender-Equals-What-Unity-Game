using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FillFood : MonoBehaviour
{
    public Slider slider;
    public GameObject food;
    public float fillspeed = 0.4f;
    private float targetProgress = 0;
    public int cnt = 0;
    public AudioSource source;
    public AudioClip clip;
    public float rotateSpeed = 15f;
    public GameObject c1;

    // Start is called before the first frame update
    void Start()
    {
        c1.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (slider.value < targetProgress)
        {
            slider.value += fillspeed * Time.deltaTime;
        }

        
            fill();
        
    }
    

    public void fill()
    {
        if (Input.GetMouseButtonDown(0))
        {
            source.PlayOneShot(clip);
            IncrementProgress(0.166f);
            food.transform.Rotate(Vector3.forward * rotateSpeed);
            cnt++;
        }
        if (cnt == 6)
        {
            c1.SetActive(true);
        }
    }

    public void IncrementProgress(float newProg)
    {
        targetProgress = slider.value + newProg;
    }
}
