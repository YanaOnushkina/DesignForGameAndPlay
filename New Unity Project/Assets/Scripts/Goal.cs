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
<<<<<<< HEAD
            levelComplete.SetActive(true);
=======
            FindObjectOfType<GameManager>().CompleteLevel();
            FindObjectOfType<AudioManager>().Play("Falling");
>>>>>>> c4ba504702f6a68970491889d2a74206ea1a43bc

        }

    }

}