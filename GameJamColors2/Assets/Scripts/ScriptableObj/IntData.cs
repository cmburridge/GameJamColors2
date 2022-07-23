using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu]
public class IntData : ScriptableObject
{
    public int value = 0;

    public void IncreaseValue()
    {
        value += 1;
    }
}
