using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerBehavior : MonoBehaviour
{
    public UnityEvent onTrigger;

    private void OnTriggerEnter2D(Collider2D other)
    {
        onTrigger.Invoke();
    }
}
