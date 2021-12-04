using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LiftWeight : MonoBehaviour
{
    public GameObject print1;
    public GameObject print2;
    public GameObject print3;
    public GameObject check;

    private int cnt = 0;

    public GameObject dumbbell;

    // Start is called before the first frame update
    void Start()
    {
        print1.SetActive(false);
        print2.SetActive(false);
        print3.SetActive(false);
        check.SetActive(false);

        Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        Printprint();

        if (print1.activeSelf && print2.activeSelf && print3.activeSelf)
        {
            Debug.Log("Workout Done!");
            check.SetActive(true);
        }
    }

    void Printprint()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 pos = Input.mousePosition;
            Collider2D hitCollider = Physics2D.OverlapPoint(Camera.main.ScreenToWorldPoint(pos));

            if (hitCollider != null && hitCollider.CompareTag("dumbbell") && cnt == 0)
            {
                Debug.Log("hit");
                Destroy(GameObject.FindWithTag("dumbbell"));
                print1.SetActive(true);
                cnt++;
                Spawn();
            }
            else if (hitCollider != null && hitCollider.CompareTag("dumbbell") && cnt == 1)
            {
                Debug.Log("hit");
                Destroy(GameObject.FindWithTag("dumbbell"));
                print2.SetActive(true);
                cnt++;
                Spawn();
            }
            else if (hitCollider != null && hitCollider.CompareTag("dumbbell") && cnt == 2)
            {
                Debug.Log("hit");
                Destroy(GameObject.FindWithTag("dumbbell"));
                print3.SetActive(true);
                cnt++;
            }
        }
    }

    private void Spawn()
    {
        bool spawned = false;
        while (!spawned)
        {
            Vector3 pos = new Vector3(Random.Range(-7f, 7f), Random.Range(-4f, 4f), 0f);
            if ((pos - transform.position).magnitude < 3)
            {
                continue;
                Debug.Log("Spawned");
            }
            else
            {
                Instantiate(dumbbell, pos, Quaternion.identity);
                spawned = true;
                Debug.Log("Already Spawned");
            }
        }
    }



}
