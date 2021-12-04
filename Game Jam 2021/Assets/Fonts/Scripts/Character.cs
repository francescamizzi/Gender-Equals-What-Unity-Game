using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public string gender;

    public Character (string _gender)
    {
        gender = _gender;
    }

    public void sayHi()
    {
        if(gender == "Male")
        {
            Debug.Log("I like blue");
        }
        if(gender == "Female")
        {
            Debug.Log("I like pink");
        }
        
    }

}
