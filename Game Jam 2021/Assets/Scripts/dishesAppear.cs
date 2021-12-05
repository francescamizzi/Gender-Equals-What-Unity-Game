using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dishesAppear : MonoBehaviour
{
    public GameObject cleanDishes;
    // Start is called before the first frame update
    void Start()
    {
        cleanDishes.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void cleanDishesAppear(bool success)
    {
        if (success == true)
        {
            cleanDishes.SetActive(true);
        }
    }
}
