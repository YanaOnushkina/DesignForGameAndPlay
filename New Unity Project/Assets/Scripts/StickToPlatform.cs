using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickToPlatform : MonoBehaviour
{
    public Rigidbody paws;
    public Transform platform;

    private void Start()
    {

        paws.transform.parent = platform;


    }


    private void Update()
    {
        //Debug.Log("hey");
    }

    //void OnTriggerEnter(Collider other)
    //{
    //    Debug.Log("not stick");
    //    Debug.Log(other.name);
    //    Debug.Log(other.tag);
    //    if (other.gameObject.tag == "Platform")
    //    {
    //        //This will make the player a child of the Obstacle
    //        Debug.Log("stick");
    //        paws.transform.parent = other.gameObject.transform; //Change "myPlayer" to your player
    //    }
    //}
}
