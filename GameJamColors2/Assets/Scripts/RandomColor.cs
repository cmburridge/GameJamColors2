using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class RandomColor : MonoBehaviour
{
    Color[] colors = { new Color(0,1,0,1), new Color(1,0,0,1), new Color(0,0,1,1),  new Color(1,1,0,1)};
    public bool isRed;
    public bool isGreen;
    public bool isBlue;
    public bool isYellow;
    void Start()
    {
        GetComponent<SpriteRenderer>().material.color = colors[Random.Range(0,colors.Length)];
    }

    private void Update()
    {
        if (GetComponent<SpriteRenderer>().material.color == new Color(0,1,0,1))
        {
            isGreen = true;
        }
        if (GetComponent<SpriteRenderer>().material.color == new Color(1,0,0,1))
        {
            isRed = true;
        }
        if (GetComponent<SpriteRenderer>().material.color == new Color(0,0,1,1))
        {
            isBlue = true;
        }
        if (GetComponent<SpriteRenderer>().material.color == new Color(1,1,0,1))
        {
            isYellow = true;
        }
    }
}
