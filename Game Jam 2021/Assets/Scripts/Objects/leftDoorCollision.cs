using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class leftDoorCollision : MonoBehaviour
{
    private GameObject leftDoorBox;
    private Vector3 scaleChange;
    private Vector3 startScale;
    // Start is called before the first frame update
    void Start()
    {
        leftDoorBox = GameObject.FindGameObjectWithTag("leftDoorBox");
        scaleChange = new Vector3(2.346f, 1.545937f, 1f);

         startScale=transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Hadmet");
            leftDoorBox.transform.localScale += scaleChange;
            //makeBedBox.SetActive(true);
        }
    }

    public void closeBox(){
        leftDoorBox.transform.localScale = startScale;
    }

    /*public void ToggleBox()
    {
        makeBedBox.SetActive(true);
    }*/
}
