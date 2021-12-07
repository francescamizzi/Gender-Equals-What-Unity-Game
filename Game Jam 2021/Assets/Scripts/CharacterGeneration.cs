using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterGeneration : MonoBehaviour
{
    public static List<string> genders = new List<string> { "Male", "Female" };

    public string gender;

    Character mChar;

    public GameObject femaleEnding;
    public GameObject maleEnding;


    public void RandomChar()
    {

        int rndG = Random.Range(0, genders.Count);
        Debug.Log(rndG);

        //Character newChar = new Character(genders[rndG]);

        if (rndG == 0)
        {
            maleEnding.SetActive(true);
            Debug.Log("Male");
        }

        else if (rndG == 1)
        {
            femaleEnding.SetActive(true);
            Debug.Log("Female");

        }

        //return newChar;
    }

    void Start()
    {
        femaleEnding.SetActive(false);
        maleEnding.SetActive(false);

        //RandomChar();
        //mChar.sayHi();
        //Debug.Log(gen);

        
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            RandomChar();
        }
    }
}
