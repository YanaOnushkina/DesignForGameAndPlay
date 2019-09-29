using UnityEngine;

public class EndTrigger : MonoBehaviour
{

    public GameManager gameManager;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "")
        Debug.Log("issue_1");
        gameManager.CompleteLevel();

    }

}
