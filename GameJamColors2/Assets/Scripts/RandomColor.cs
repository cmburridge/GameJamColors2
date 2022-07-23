using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class RandomColor : MonoBehaviour
{
    public bool set1;
    Color[] colors1 = { new Color(0,1,1,1), new Color(1,0,1,1), new Color(0,1,0,1)};
    public bool set2;
    Color[] colors2 = { new Color(.5f,.5f,.5f,1), new Color(0f,0f,1f,1), new Color(1,0.92f,0.016f,1)};
    
    public TargetData targetColor;
    public IntData turnCount;
    public IntData foodCount;
    public IntData health;

    public SpriteRenderer sR;
    public SpriteRenderer original;
    void Start()
    {
        int newColor = Random.Range(0, colors1.Length);
        original.material.color = colors1[newColor];
        sR.material.color = colors2[newColor];
    }
    
    public void CheckColor()
    {
        if (GetComponent<SpriteRenderer>().material.color == targetColor.wantedColor)
        {
            turnCount.value += 1;
            foodCount.value += 1;
        }
        else
        {
            health.value += -1;
        }
    }
}
