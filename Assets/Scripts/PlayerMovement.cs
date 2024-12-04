using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 10;
    private float move;
    private float yBoundaries = -20;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        

        // movement controls for right, left, and jumping
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {

            move = Input.GetAxis("HorizontalInput");

            transform.Translate(Vector3.forward * speed * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) 
        {

            move = Input.GetAxis("HorizontalInput");

            transform.Translate(Vector3.right * speed * Time.deltaTime);

        }
        // ADD SINGLE AND DOUBLE JUMP. 
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.Space))
        {

            transform.Translate(Vector3.up * speed * Time.deltaTime);

        }


        // boundaries so that if the player falls they despawn
        if (transform.position.y < yBoundaries)
        {

            Destroy(gameObject);

        }




    }

    // add collision to the ground so that the player stops falling though the ground



}
