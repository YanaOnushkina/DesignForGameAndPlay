using UnityEngine;
using UnityEngine.SceneManagement; //used when need to change between scenes or relaod the scene that are on now

public class GameManager : MonoBehaviour
{

    bool gameHasEnded = false;

    public float restartDelay = 1f;

    //public GameObject completeLevelUI;
 
    public void CompleteLevel()
    {

        //completeLevelUI.SetActive(true);

    }

    public void EndGame()
    {
        if (gameHasEnded == false)
        {

            gameHasEnded = true;
            Invoke("Restart", restartDelay);

        }

    }

    void Restart()
    {

        Debug.Log("hi");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}
