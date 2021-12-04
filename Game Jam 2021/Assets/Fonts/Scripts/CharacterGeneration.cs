using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterGeneration : MonoBehaviour
{
    public static List<string> genders = new List<string> { "Male", "Female" };

    public static Character RandomChar()
    {
        int rndG = Random.Range(0, genders.Count);
        //Debug.Log(rndG);

        //create new char 
        Character newChar = new Character(genders[rndG]);

        return newChar;
    }
}
