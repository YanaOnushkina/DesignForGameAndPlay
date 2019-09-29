using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickToPlatform : MonoBehaviour
{
    public Rigidbody paws;

    private void Update()
    {
        //Debug.Log("hey");
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("not stick");
        if (other.gameObject.name == "Platform")
        {
            //This will make the player a child of the Obstacle
            Debug.Log("stick");
            paws.transform.parent = other.gameObject.transform; //Change "myPlayer" to your player
        }
    }
}
