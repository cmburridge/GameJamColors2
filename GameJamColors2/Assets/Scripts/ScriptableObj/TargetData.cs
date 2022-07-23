using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class TargetData : ScriptableObject
{
    Color[] colors1 = { new Color(0,1,1,1), new Color(1,0,1,1), new Color(.3f,1,0,1)};
    public Color wantedColor;
    Color[] colors2 = { new Color(.7f,.6f,.5f,1), new Color(.2f,.2f,.9f,1), new Color(.8f,0.92f,0.016f,1)};
    public Color Ui;

    public void WantedColor()
    {
        int newColor = Random.Range(0, colors1.Length);
        wantedColor = colors1[newColor];
        Ui = colors2[newColor];
    }
}
