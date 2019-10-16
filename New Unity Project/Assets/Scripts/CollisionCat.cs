using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionCat : MonoBehaviour
{
    public GameObject life1;
    public GameObject life2;
    public GameObject life3;
    public GameObject winScreen;
    int counter = 0;
    public int returnDelay = 2;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision");
        Debug.Log("counter" + counter);
        Debug.Log("tag" + other.tag);
        if (other.tag == "Box" && counter == 0)
        {
            //FindObjectOfType<GameManager>().CompleteLevel();
            life1.SetActive(false);
        }
        if (other.tag == "Box" && counter == 1)
        {
            //FindObjectOfType<GameManager>().CompleteLevel();
            life2.SetActive(false);
        }
        if (other.tag == "Box" && counter == 2)
        {
            //FindObjectOfType<GameManager>().CompleteLevel();
            life3.SetActive(false);
            Invoke("WinScreen", 1);
        }
        if (other.tag == "Box")
        {

            counter += 1;
        }

    }

    void WinScreen()
        {
            winScreen.SetActive(true);
            Invoke("GoToMenu", returnDelay);
        }
    void GoToMenu()
    {
        FindObjectOfType<GameManager>().CompleteLevel();
    }
}
