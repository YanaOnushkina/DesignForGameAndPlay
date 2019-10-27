using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public Rigidbody player;
    public Rigidbody platform;
    public float mass;
    bool hit = false;
    public GameObject levelComplete;

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
            levelComplete.SetActive(true);
            levelComplete.SetActive(true);
            FindObjectOfType<AudioManager>().Play("Level Finished");

        }

    }

}