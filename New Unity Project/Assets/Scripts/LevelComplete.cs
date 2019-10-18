using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelComplete : MonoBehaviour
{
    public void LevelCompleteCall()
    {
        FindObjectOfType<GameManager>().CompleteLevel();
    }
}
