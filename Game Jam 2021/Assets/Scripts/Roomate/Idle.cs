using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Idle : StateMachineBehaviour
{
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        
    }


    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

        animator.SetBool("isWandering", true);
    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        //Instantiate(effect, animator.transform.position, Quaternion.identity);

        
    }
}
