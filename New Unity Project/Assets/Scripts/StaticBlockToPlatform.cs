using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticBlockToPlatform : MonoBehaviour
{
    public Transform cube;
    public Transform platform;
    // Start is called before the first frame update
    void Start()
    {

        cube.parent = platform;

    }
}
