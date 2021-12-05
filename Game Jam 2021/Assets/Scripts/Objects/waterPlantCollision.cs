using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class waterPlantCollision : MonoBehaviour
{

    private GameObject waterPlantsBox;
    private Vector3 scaleChange;

    // Start is called before the first frame update
    void Start()
    {
        waterPlantsBox = GameObject.FindGameObjectWithTag("waterPlantsBox");
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
            waterPlantsBox.transform.localScale += scaleChange;
            //makeBedBox.SetActive(true);
        }
    }

    public void changeScene()
    {
        waterPlantsBox.SetActive(false);
        SceneManager.LoadScene("PlantWatering", LoadSceneMode.Additive);
    }
}
