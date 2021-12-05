using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gymTextBox : MonoBehaviour
{
    private Vector3 scaleChange;
    private Vector3 scaleReset;
    private GameObject textBox;

    bool istrue = false;
    int cnt = 0;

    // Start is called before the first frame update
    void Start()
    {
        scaleChange = new Vector3(1, 1, 1);
        scaleReset = new Vector3(0, 0, 0);
        textBox = GameObject.FindGameObjectWithTag("gymTextBox");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToggleBox(){
        textBox.transform.localScale += scaleChange;
    }

    public void changeScene()
    {
        SceneManager.LoadScene("GYM");
        textBox.SetActive(false);
        
    }

}
