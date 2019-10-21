using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeOver : MonoBehaviour
{
    public void RestartCall()
    {
        FindObjectOfType<GameManager>().EndGame();
    }
}
