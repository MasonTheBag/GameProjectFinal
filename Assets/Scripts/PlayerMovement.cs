using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    private Rigidbody playerRb;
    private bool isGrounded = true;
    public float speed = 10;
    public float jumpForce = 0.5f;
    private float yBoundaries = -100;

    // Start is called before the first frame update
    void Start()
    {
        
        playerRb = GetComponent<Rigidbody>();


    }

    // Update is called once per frame
    void Update()
    {


        // movement controls for right, left, and jumping
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {

            transform.Translate(Vector3.left * speed * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) 
        {

            transform.Translate(Vector3.right * speed * Time.deltaTime);

        }

        // Jumping mechanics 
        if ((Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)) && isGrounded)
        {

           
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);

            isGrounded = false;


        }


        // boundaries so that if the player falls they respawn
        if (transform.position.y < yBoundaries)
        {

            Scene currentScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(currentScene.name);

        }


    }

    // collides with ground or walls to allow player to jump again
    private void OnCollisionEnter(Collision collision)
    {
       
        isGrounded = true;


    }

}
