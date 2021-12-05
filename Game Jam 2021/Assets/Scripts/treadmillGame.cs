using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Treadmill : MonoBehaviour
{
    public GameObject shoeprint1;
    public GameObject shoeprint2;
    public GameObject shoeprint3;

    private int cnt = 0;

    // Start is called before the first frame update
    void Start()
    {
        shoeprint1.SetActive(false);
        shoeprint2.SetActive(false);
        shoeprint3.SetActive(false);

        //Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        PrintShoeprint();

        if (shoeprint1.activeSelf && shoeprint2.activeSelf && shoeprint3.activeSelf)
        {
            Debug.Log("Treadmill Done!");
        }
    }

    void PrintShoeprint()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 pos = Input.mousePosition;
            Collider2D hitCollider = Physics2D.OverlapPoint(Camera.main.ScreenToWorldPoint(pos));

            if (cnt == 0)
            {
                Debug.Log("hit");
                shoeprint1.SetActive(true);
                cnt++;
            }
            else if (cnt == 1)
            {
                shoeprint2.SetActive(true);
                cnt++;
            }
            else if (cnt == 2)
            {
                shoeprint3.SetActive(true);
                cnt++;
            }
        }
    }

    // private void Spawn()
    // {
    //     bool spawned = false;
    //     while (!spawned)
    //     {
    //         Vector3 pos = new Vector3(Random.Range(-7f, 7f), Random.Range(-4f, 4f), 0f);
    //         if ((pos - transform.position).magnitude < 3)
    //         {
    //             continue;
    //             Debug.Log("Spawned");
    //         }
    //         else
    //         {
    //             Instantiate(ball, pos, Quaternion.identity);
    //             spawned = true;
    //             Debug.Log("Already Spawned");
    //         }
    //     }
    // }
}