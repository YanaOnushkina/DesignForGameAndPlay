using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionCat : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("COllision");
        if (other.tag == "Box")
        {
            FindObjectOfType<GameManager>().CompleteLevel();

        }

    }
}
