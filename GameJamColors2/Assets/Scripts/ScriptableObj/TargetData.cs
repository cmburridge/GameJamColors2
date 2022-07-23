using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class TargetData : ScriptableObject
{
    private Color[] colors = {new Color(0, 1, 0, 1), new Color(1, 0, 0, 1), new Color(0, 0, 1, 1), new Color(1, 1, 0, 1)};
    public Color wantedColor;
    
    public void WantedColor()
    {
        wantedColor = colors[Random.Range(0, colors.Length)];
    }
}
