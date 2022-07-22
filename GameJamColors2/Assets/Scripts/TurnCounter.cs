using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TurnCounter : MonoBehaviour
{
    public int time;
    public UnityEvent turnStart;

    private void Update()
    {
        time += 1;
        Debug.Log(time);
        
        if (time >= 5000)
        {
            time = 0;
            turnStart.Invoke();
        }
    }
}
