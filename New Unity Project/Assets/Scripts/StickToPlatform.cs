using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickToPlatform : MonoBehaviour
{
    public Rigidbody paws;
    public GameObject paw;
    public Vector3 position;
    public Transform blockRotation;
    public Transform blockRotationOpposite;
    public float timeBetween = 7f;

    private void Update()
    {
        timeBetween -= Time.deltaTime;
        if (GameObject.FindGameObjectWithTag("cat_paw") == null)
        {
            if(timeBetween > 0)
            {
                Debug.Log("paw");
                StartCoroutine(Wait());
                float x = -8.41f;
                float y = 0;
                float z = Random.Range(-8.33f, 8.33f);
                position = new Vector3(x, y, z);
                Instantiate(paws, position, blockRotation.rotation);

            }
            if (timeBetween <= 0)
            {
                Debug.Log("paw 1");
                StartCoroutine(Wait());
                float x = 8.41f;
                float y = 15;
                float z = Random.Range(-8.33f, 8.33f);
                position = new Vector3(x, y, z);
                Instantiate(paws, position, blockRotation.rotation);
                timeBetween = 7f;
            }
        }

    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(3);
    }
}