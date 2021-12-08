using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dumbbells : MonoBehaviour
{
    private GameObject weightBox;
    private Vector3 scaleChange;

    // Start is called before the first frame update
    void Start()
    {
        weightBox = GameObject.FindGameObjectWithTag("weightBox");
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
            weightBox.transform.localScale += scaleChange;
            //minigame
        }
    }

    public void changeScene()
    {
        Debug.Log("Go team");
        weightBox.SetActive(false);
        SceneManager.LoadScene("weights", LoadSceneMode.Additive);
    }
}