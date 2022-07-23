using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UpdateBar : MonoBehaviour
{
    public IntData health;
    public Slider bar;
    public GameObject player;

    private void Update()
    {
        bar.value = health.value;
        if (bar.value == 0)
        {
            Destroy(player);
        }
    }
}
