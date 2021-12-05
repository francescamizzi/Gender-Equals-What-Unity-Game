using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shelfCollision : MonoBehaviour
{
    private GameObject shelfBox;
    private GameObject image;
    private Vector3 scaleChange;
    private Vector3 imageChange;
    public static List<string> genders = new List<string> { "Male", "Female" };
    public int rndG;
    // public Character gender;

    // public CharacterGeneration chargen;

    // Start is called before the first frame update
    void Start()
    {
        shelfBox = GameObject.FindGameObjectWithTag("shelfBox");
        image = GameObject.FindGameObjectWithTag("femaleEnding");
        scaleChange = new Vector3(2.346f, 1.545937f, 1f);
        imageChange = new Vector3(2,2,0);
        rndG = Random.Range(0, genders.Count);

        Debug.Log(rndG);
        // chargen = GameObject.FindObjectOfType(typeof(CharacterGeneration)) as CharacterGeneration;
        // gender = chargen.RandomChar();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //Debug.Log(gender.gender);
            shelfBox.transform.localScale += scaleChange;
            //makeBedBox.SetActive(true);
        }
    }



    public void showPicture(){ 
        image.transform.localScale += scaleChange;
    }

    public void ToggleBox(){ 
        shelfBox.SetActive(false);
    }

}
