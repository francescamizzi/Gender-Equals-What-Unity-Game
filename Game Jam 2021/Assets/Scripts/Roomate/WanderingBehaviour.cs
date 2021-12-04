using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WanderingBehaviour : StateMachineBehaviour
{
    private PatrolSpots patrol;
    public float speed = 3;
    private int randomSpot;


    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        patrol = GameObject.FindGameObjectWithTag("PatrolSpots").GetComponent<PatrolSpots>();
        randomSpot = Random.Range(0, patrol.patrolPoints.Length);
    }


    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        
        if (Vector2.Distance(animator.transform.position, patrol.patrolPoints[randomSpot].position) > 0.2f)
        {
            animator.transform.position = Vector2.MoveTowards(animator.transform.position, patrol.patrolPoints[randomSpot].position, speed * Time.deltaTime);
        

        }
        else
        {
            randomSpot = Random.Range(0, patrol.patrolPoints.Length);
        }

    }


    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }
}
