using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private float speed = 10;
    private Vector3 movement;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // Handle left and right movement (A and D)
        if (Input.GetKey(KeyCode.A)) // Move left
        {
            movement += Vector3.left;
        }
        if (Input.GetKey(KeyCode.D)) // Move right
        {
            movement += Vector3.right;
        }

        // Normalize movement to prevent faster diagonal movement
        movement = movement.normalized * speed * Time.deltaTime;


    }
}
