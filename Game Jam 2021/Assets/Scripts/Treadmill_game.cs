using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Treadmill_game : MonoBehaviour
{
    public GameObject shoeprint1;
    public GameObject shoeprint2;
    public GameObject shoeprint3;
    public GameObject ball;

    private int cnt = 0;

    // Start is called before the first frame update
    void Start()
    {
        shoeprint1.SetActive(false);
        shoeprint2.SetActive(false);
        shoeprint3.SetActive(false);

        Spawn();
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
                Destroy(GameObject.FindWithTag("ball"));
                cnt++;
                Spawn();
            }
            else if (cnt == 1)
            {
                shoeprint2.SetActive(true);
                Destroy(GameObject.FindWithTag("ball"));
                cnt++;
                Spawn();
            }
            else if (cnt == 2)
            {
                shoeprint3.SetActive(true);
                Destroy(GameObject.FindWithTag("ball"));
                cnt++;
                Debug.Log("Should exit");
                SceneManager.UnloadSceneAsync("treadmill");
            }
        }
    }

    private void Spawn()
    {
        bool spawned = false;
        while (!spawned)
        {
            Vector3 pos = new Vector3(Random.Range(-7f, 7f), Random.Range(86f, 92f), 0f);
            if ((pos - transform.position).magnitude < 3)
            {
                continue;
                Debug.Log("Spawned");
            }
            else
            {
                Instantiate(ball, pos, Quaternion.identity);
                spawned = true;
                Debug.Log("Already Spawned");
            }
        }
    }
}