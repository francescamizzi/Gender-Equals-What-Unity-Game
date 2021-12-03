///Description;
/// This is the class for the player controller. It controls the behaviour of the ball 
/// in the MiniGame scene. 
///


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private int score = 0;
    public Text countText;
    private bool isTouching = true;
    private Rigidbody rb;
    public float movementSpeed = 1.0f;
    public AudioSource audio;
    public AudioClip audioClip;

    GameData gameData;

    private void Start()
    {
        //We retrieve the GameData component of the GameManager game object holding the player name and score 
        gameData = GameObject.FindGameObjectWithTag("gamedata").GetComponent<GameData>();

        rb = GetComponent<Rigidbody>();
        SetCountText();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * movementSpeed);

        if ((Input.GetKey(KeyCode.Space)) && isTouching)
        {
            Vector3 movementJump = new Vector3(0.0f, 6.0f, 0.0f);
            rb.AddForce(movementJump * movementSpeed);
        }

        isTouching = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("pickup"))
        {
            score = score + 1;
            other.gameObject.SetActive(false);

            SetCountText();
            audio.PlayOneShot(audioClip);
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        isTouching = true;
    }

    void SetCountText()
    {
        countText.text = "Score: " + score;

        gameData.UpdateScore(score);

        if(score == 12)
        {
            SceneManager.LoadScene("Endscene");
        }
    }
}
