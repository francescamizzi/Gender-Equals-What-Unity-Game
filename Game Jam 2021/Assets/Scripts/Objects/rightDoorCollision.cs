using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class rightDoorCollision : MonoBehaviour
{
    private GameObject rightDoorBox;
    private Vector3 scaleChange;
    private Vector3 startScale;
    // Start is called before the first frame update
    void Start()
    {
        rightDoorBox = GameObject.FindGameObjectWithTag("rightDoorBox");
        scaleChange = new Vector3(2.346f, 1.545937f, 1f);
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
            rightDoorBox.transform.localScale += scaleChange;
            //makeBedBox.SetActive(true);
        }
    }

    public void changeScene()
    {
        rightDoorBox.SetActive(false);
        SceneManager.LoadScene("Mall");
    }

    /*public void ToggleBox()
    {
        makeBedBox.SetActive(true);
    }*/
}
