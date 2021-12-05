using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bedroomDoorCollision : MonoBehaviour
{
    private GameObject leaveRoomBox;
    private GameObject tasksLeftBox;
    private GameObject blanket;
    private Vector3 scaleChange;
    private Vector3 startScale;
    // Start is called before the first frame update
    void Start()
    {
        leaveRoomBox = GameObject.FindGameObjectWithTag("leaveRoomBox");
        tasksLeftBox = GameObject.FindGameObjectWithTag("tasksLeftBox");
        blanket = GameObject.FindGameObjectWithTag("tidyBlanket");
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

            if(blanket.activeSelf){
                leaveRoomBox.transform.localScale += scaleChange;
            } else{
                tasksLeftBox.transform.localScale += scaleChange;
            }
            
            //makeBedBox.SetActive(true);
        }
    }

    public void changeScene()
    {
        leaveRoomBox.SetActive(false);
        SceneManager.LoadScene("LivingRoom");
    }

    public void closeBox(){
        tasksLeftBox.transform.localScale = startScale;
    }

    /*public void ToggleBox()
    {
        makeBedBox.SetActive(true);
    }*/
}
