using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionCat : MonoBehaviour
{
    public GameObject life1;
    public GameObject life2;
    public GameObject life3;
    public GameObject winScreen;
    int counter = 0;
    public int returnDelay = 2;
    public Rigidbody player;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision");
        Debug.Log("counter" + counter);
        Debug.Log("tag" + other.tag);
        if (other.tag == "Box" && life1.activeSelf == true)
        {
            //FindObjectOfType<GameManager>().CompleteLevel();
            life1.SetActive(false);
        }
        if (other.tag == "Box" && life1.activeSelf == false && life2.activeSelf == true && life3.activeSelf == true && counter == 1)
        {
            //FindObjectOfType<GameManager>().CompleteLevel();
            life2.SetActive(false);
        }
        if (other.tag == "Box" && life1.activeSelf == false && life2.activeSelf == false && life3.activeSelf == true && counter == 2)
        {
            //FindObjectOfType<GameManager>().CompleteLevel();
            life3.SetActive(false);
            WinScreen();
        }
        if (other.tag == "Box")
        {
            counter += 1;
        }

    }

    void WinScreen()
    {
        player.isKinematic = true;
        Debug.Log("FINISH THE GAME");
        winScreen.SetActive(true);

    }
}
