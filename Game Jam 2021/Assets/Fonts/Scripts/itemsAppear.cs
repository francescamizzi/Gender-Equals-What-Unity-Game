using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemsAppear : MonoBehaviour
{

    public GameObject niceBlanket;
    public GameObject clothes;
    // Start is called before the first frame update
    void Start()
    {
        niceBlanket.SetActive(false);
        clothes.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void blanketAppears(bool success)
    {
        if (success == true)
        {
            niceBlanket.SetActive(true);
        }
    }

    public void clothesDisappear(bool success)
    {
        if (success == true)
        {
            clothes.SetActive(false);
        }
    }
}
