using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;

    public float sideForce = 500f;
    bool grounded = false;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (rb.position.y < 1 || grounded == true)
        {
            grounded = true;
            //move around
            if (Input.GetKey("right"))
            {
                rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
                FindObjectOfType<AudioManager>().Play("Rolling");
                FindObjectOfType<AudioManager>().Play("Scratching");
            }

            if (Input.GetKey("left"))
            {
                rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
                FindObjectOfType<AudioManager>().Play("Rolling");
                FindObjectOfType<AudioManager>().Play("Scratching");
            }

            if (Input.GetKey("up"))
            {
                rb.AddForce(0, 0, sideForce * Time.deltaTime, ForceMode.VelocityChange);
                FindObjectOfType<AudioManager>().Play("Rolling");
                FindObjectOfType<AudioManager>().Play("Scratching");
            }

            if (Input.GetKey("down"))
            {
                rb.AddForce(0, 0, -sideForce * Time.deltaTime, ForceMode.VelocityChange);
                FindObjectOfType<AudioManager>().Play("Rolling");
                FindObjectOfType<AudioManager>().Play("Scratching");
            }

            //checks if the player is on the ground
            if (rb.position.y < -10f)
            {
                FindObjectOfType<AudioManager>().Play("Falling");
                FindObjectOfType<GameManager>().EndGame();
            }

        }
    }
}
