using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bathroomCollision : MonoBehaviour
{

    private GameObject bathroomBox;
    private Vector3 scaleChange;
    private Vector3 startScale;

    // Start is called before the first frame update
    void Start()
    {
        bathroomBox = GameObject.FindGameObjectWithTag("gymTextBox");
        scaleChange = new Vector3(1, 1, 1f);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Hadmet");
            bathroomBox.transform.localScale += scaleChange;
            //makeBedBox.SetActive(true);
        }
    }

    public void changeScene()
    {
        bathroomBox.SetActive(false);
        SceneManager.LoadScene("BedroomEnd");
    }
}
