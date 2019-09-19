using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{

    //test

    public Rigidbody player;
    public Rigidbody platform;
    public float mass;
    bool hit = false;

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Goal" && hit == false)
        {

            hit = true;
            player.isKinematic = true;
            platform.isKinematic = true;


            Debug.Log("You Win!");

        }

    }

}