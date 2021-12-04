using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class makeBedCollision : MonoBehaviour
{
    private GameObject makeBedBox;
    private GameObject messyBlanket;
    private Vector3 scaleChange;
    // Start is called before the first frame update
    void Start()
    {
        makeBedBox = GameObject.FindGameObjectWithTag("makeBedBox");
        messyBlanket = GameObject.FindGameObjectWithTag("messyBlanket");
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
            makeBedBox.transform.localScale += scaleChange;
            //makeBedBox.SetActive(true);
        }
    }

    public void changeScene()
    {
        makeBedBox.SetActive(false);
        messyBlanket.SetActive(false);
        SceneManager.LoadScene("makebed", LoadSceneMode.Additive);
    }

    /*public void ToggleBox()
    {
        makeBedBox.SetActive(true);
    }*/
}
