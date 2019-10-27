using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parent : MonoBehaviour
{
    public Transform platfrom;
    private void OnTriggerExit(Collider other)
    {
        other.transform.parent = platfrom;
    }
}
