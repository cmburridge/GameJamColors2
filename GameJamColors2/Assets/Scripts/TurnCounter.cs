using System;
using UnityEngine;
using UnityEngine.Events;

public class TurnCounter : MonoBehaviour
{
    public IntData turnCount;
    public int checkpoint = 3;
    public UnityEvent turnStart;

    private void Start()
    {
        turnStart.Invoke();
    }

    private void Update()
    {
        if (turnCount.value > checkpoint)
        {
            checkpoint += 3;
            turnStart.Invoke();
        }
    }
}
