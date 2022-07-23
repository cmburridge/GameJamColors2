using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeDirection : MonoBehaviour
{
    public GameObject controller;
    void Update()
    {
        transform.rotation = Quaternion.Euler(0,0,0);
    }

    public void reverseDirection()
    {
        controller.transform.Rotate(0,0,180);
    }
}
