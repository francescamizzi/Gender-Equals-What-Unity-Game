using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dogFolloq : MonoBehaviour
{
    public Transform Player;


    void Start()
    {

    }

    void Update(){
        transform.LookAt(Player);
        if(Vector3.Distance(transform.position, Player.position) > 5.0f){
            transform.position = Vector3.MoveTowards(transform.position, Player.position, Time.deltaTime);
            transform.position = new Vector3(transform.position.x, 0, transform.position.z);
        }
    }
}