using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class hitm : MonoBehaviour
{
    private Vector3 scaleChange;
    private Vector3 scaleReset;
    private GameObject maleTextBox;

    bool istrue = false;
    int cnt = 0;

    // Start is called before the first frame update
    void Start()
    {
        scaleChange = new Vector3(1, 1, 1);
        scaleReset = new Vector3(0, 0, 0);
        maleTextBox = GameObject.FindGameObjectWithTag("maleTextBox");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log(scaleChange);
            Debug.Log(scaleReset);

            maleTextBox.transform.localScale += scaleChange;
            istrue = true;
            cnt++;

            Debug.Log("Hadmet");
            Destroy(gameObject);
            //make text bubble

            // if(istrue == true && cnt == 1)
            void OnMouseDown()
            {
                maleTextBox.transform.localScale -= scaleChange;
            }
        }
    }

    public void changeScene()
    {
        SceneManager.LoadScene("LivingRoom2");
        maleTextBox.SetActive(false);
        
    }

    public void ToggleBox(){

    }
}
