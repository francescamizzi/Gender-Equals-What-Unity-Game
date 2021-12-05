using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cleanDishesCollision : MonoBehaviour
{

    private GameObject cleanDishesBox;
    private Vector3 scaleChange;

    // Start is called before the first frame update
    void Start()
    {
        cleanDishesBox = GameObject.FindGameObjectWithTag("cleanDishesBox");
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
            cleanDishesBox.transform.localScale += scaleChange;
            //makeBedBox.SetActive(true);
        }
    }

    public void changeScene()
    {
        cleanDishesBox.SetActive(false);
        SceneManager.LoadScene("WashingDishes", LoadSceneMode.Additive);
    }
}
