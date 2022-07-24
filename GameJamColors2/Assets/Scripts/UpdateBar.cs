using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class UpdateBar : MonoBehaviour
{
    public IntData health;
    public Slider bar;
    public GameObject player;
    public bool isHealth;
    public UnityEvent onDeath;

    public GameObject prefab;

    private void Update()
    {
        bar.value = health.value;
        if (bar.value == 0 && isHealth == true)
        {
            Instantiate(prefab, player.transform.position, Quaternion.identity);
            onDeath.Invoke();
            Destroy(player);
        }
    }
}
