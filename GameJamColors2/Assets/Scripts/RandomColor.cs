using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class RandomColor : MonoBehaviour
{
    Color[] colors = { new Color(0,1,0,1), new Color(1,0,0,1), new Color(0,0,1,1),  new Color(1,1,0,1)};

    public TargetData targetColor;
    public IntData turnCount;
    public IntData health;
    void Start()
    {
        GetComponent<SpriteRenderer>().material.color = colors[Random.Range(0,colors.Length)];
    }
    
    public void CheckColor()
    {
        if (GetComponent<SpriteRenderer>().material.color == targetColor.wantedColor)
        {
            turnCount.value += 1;
        }
        else
        {
            health.value += -1;
        }
    }
}
