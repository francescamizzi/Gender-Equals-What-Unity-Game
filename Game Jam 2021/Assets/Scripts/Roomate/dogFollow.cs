using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dogFollow : MonoBehaviour
{
    public Transform Player;
    private float speed = 3f;

    void Start()
    {

    }

    void Update()
    {
        transform.LookAt(Player.position);
        transform.Rotate(new Vector3(0, -90, 0), Space.Self);

        if (Vector3.Distance(transform.position, Player.position) > 1f)
        {
            transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
        }
    }
}