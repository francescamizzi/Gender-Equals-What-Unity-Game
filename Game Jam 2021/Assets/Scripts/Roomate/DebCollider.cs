using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebCollider : MonoBehaviour
{

    private Animator anim;
    public Dialogue dialogue;

    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Hadmet");
            anim.SetBool("isWandering", false);
            TriggerDialogue();
            
        }

        void TriggerDialogue()
        {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        }
    }
}
