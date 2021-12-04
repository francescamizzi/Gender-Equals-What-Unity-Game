using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemsAppear : MonoBehaviour
{

    public GameObject niceBlanket;
    // Start is called before the first frame update
    void Start()
    {
        niceBlanket.SetActive(false);
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
}
