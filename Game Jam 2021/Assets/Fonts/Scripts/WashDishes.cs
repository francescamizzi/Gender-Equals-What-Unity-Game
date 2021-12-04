using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class WashDishes : MonoBehaviour
{
    public GameObject smudge1;
    public GameObject smudge2;
    private int cnt = 0;

    void Update()
    {
        ClearSmudge();

        if (!smudge1.activeSelf && !smudge2.activeSelf)
        {
            Debug.Log("Cleaned up plate!");
        }
    }

    void ClearSmudge()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (cnt == 0)
            {
                smudge1.SetActive(false);
                cnt++;

            }
            else if (cnt == 1)
            {
                smudge2.SetActive(false);
            }

        }
    }

}
