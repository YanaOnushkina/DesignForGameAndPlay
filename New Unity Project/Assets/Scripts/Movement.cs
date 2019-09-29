using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;

    public float sideForce = 500f;
    public float jumpSpeed = 10f;


    // Update is called once per frame
    void FixedUpdate()
    {

        //move around
        if (Input.GetKey("right"))
        {
            rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("left"))
        {
            rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("up"))
        {
            rb.AddForce(0, 0, sideForce * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (Input.GetKey("down"))
        {
            rb.AddForce(0, 0, -sideForce * Time.deltaTime, ForceMode.VelocityChange);
        }

        //jump
        if (Input.GetKey("space"))
        {
            Debug.Log("space");
            Vector3 jumpVelocity = new Vector3(0f, jumpSpeed, 0f);
            rb.velocity = rb.velocity + jumpVelocity;
            // rb.AddForce(0, -sideForce * Time.deltaTime, 0, ForceMode.VelocityChange);
        }

        //checks if the player is on the ground
        if (rb.position.y < -2f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }


    }
}
