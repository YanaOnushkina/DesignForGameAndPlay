using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingBlocks : MonoBehaviour
{

    public Transform blockRotation;
    public GameObject block;
    public float timeBetween = 15f;

    public Vector3 position;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timeBetween > 0)
        {
            timeBetween -= Time.deltaTime;

        }

        if (timeBetween <= 0)
        {
            float x = Random.Range(-10, 10);
            float y = 15;
            float z = Random.Range(-10, 10);
            position = new Vector3(x, y, z);
            Instantiate(block, position, blockRotation.rotation);
            timeBetween = 5f;

        }

    }
}
