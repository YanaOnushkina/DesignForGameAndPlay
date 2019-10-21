using UnityEngine;
using UnityEngine.UI;

public class TimeElapsed : MonoBehaviour
{
    public Text time;
    public float time_var;
    public Rigidbody player;
    public GameObject Timeover;
    bool called = false;


    // Update is called once per frame
    void Update()
    {
        time_var -= Time.deltaTime;
        time.text = time_var.ToString("0");
        if (time_var < 0.1 && called == false)
        {
            player.isKinematic = true;
            Timeover.SetActive(true);
            called = true;
        }

    }
}
