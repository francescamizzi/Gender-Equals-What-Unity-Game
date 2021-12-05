using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class treadmill : MonoBehaviour
{

    private GameObject treadmillBox;
    private Vector3 scaleChange;

    // Start is called before the first frame update
    void Start()
    {
        treadmillBox = GameObject.FindGameObjectWithTag("treadmillBox");
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
            treadmillBox.transform.localScale += scaleChange;
            //makeBedBox.SetActive(true);
        }
    }

    public void changeScene()
    {
        Debug.Log("Go team");
        treadmillBox.SetActive(false);
        SceneManager.LoadScene("Treadmill", LoadSceneMode.Additive);
    }
}
