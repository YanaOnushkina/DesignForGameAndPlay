using UnityEngine;
using UnityEngine.UI;

public class TimeElapsed : MonoBehaviour
{
    public Text time;
    public float time_var;


    // Update is called once per frame
    void Update()
    {
        time_var -= Time.deltaTime;
        time.text = time_var.ToString("0");

    }
}
