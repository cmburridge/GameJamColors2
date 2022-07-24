using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeDirection : MonoBehaviour
{
    public GameObject controller;
    private Vector2 lastPos;

    private void Start()
    {
        lastPos.x = transform.position.x;
    }

    void Update()
    {
        if (lastPos.x > transform.position.x)
        {
            transform.rotation = Quaternion.Euler(0,0,0);
            transform.Rotate(0,180,0);
        }
        else
        {
            transform.rotation = Quaternion.Euler(0,0,0);
        }
    }

    public void reverseDirection()
    {
        lastPos.x = transform.position.x;
        controller.transform.Rotate(0,0,180);
    }
}
