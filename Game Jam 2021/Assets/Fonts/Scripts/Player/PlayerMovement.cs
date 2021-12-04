using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 6f;

    private Rigidbody2D rb;
    private SpriteRenderer sr;
    private float velocity;
    private Animator anim;

    //Variables for player rotate with mouse
    private Transform playerPos;
    Vector2 mousePos;
    public float angle;


    // private AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();

        anim = GetComponent<Animator>();

        //Player rotate with mouse
        //playerPos = GetComponent<Transform>();

        //audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        //Left-Right
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-speed, 0);

            anim.SetBool("isUp", false);
            anim.SetBool("isLeft", true);
            anim.SetBool("isRight", false);
            anim.SetBool("isDown", false);

            anim.SetBool("isWalking", true);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(speed, 0);

            anim.SetBool("isUp", false);
            anim.SetBool("isLeft", false);
            anim.SetBool("isRight", true);
            anim.SetBool("isDown", false);

            anim.SetBool("isWalking", true);
        }
        //Down-Up
        else if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = new Vector2(0, -speed);

            anim.SetBool("isUp", false);
            anim.SetBool("isLeft", false);
            anim.SetBool("isRight", false);
            anim.SetBool("isDown", true);

            anim.SetBool("isWalking", true);

        }
        else if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = new Vector2(0, speed);

            anim.SetBool("isUp", true);
            anim.SetBool("isLeft", false);
            anim.SetBool("isRight", false);
            anim.SetBool("isDown", false);

            anim.SetBool("isWalking", true);

        }
        else //If no directional key is pressed
        {
            rb.velocity = new Vector2(0, 0);
            anim.SetBool("isWalking", false);
        }
    }

    void FixedUpdate()
    {
        

        //if (anim.GetBool("isWalking"))
        //{
            //if (!audio.isPlaying)
                //audio.Play();
        //}
        //else
            //audio.Stop();
        
    }
}
