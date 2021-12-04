using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cleanRoomCollision : MonoBehaviour
{
    private GameObject cleanRoomBox;
    private GameObject pileofClothes;
    private Vector3 scaleChange;
    // Start is called before the first frame update
    void Start()
    {
        cleanRoomBox = GameObject.FindGameObjectWithTag("cleanRoomBox");
        pileofClothes = GameObject.FindGameObjectWithTag("pileOfClothes");
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
            cleanRoomBox.transform.localScale += scaleChange;
            //makeBedBox.SetActive(true);
        }
    }

    public void changeScene()
    {
        cleanRoomBox.SetActive(false);
        SceneManager.LoadScene("cleanroom", LoadSceneMode.Additive);
    }

    /*public void ToggleBox()
    {
        makeBedBox.SetActive(true);
    }*/
}
