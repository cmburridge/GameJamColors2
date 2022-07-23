using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class TargetData : ScriptableObject
{
    Color[] colors1 = { new Color(0,1,1,1), new Color(1,0,1,1), new Color(0,1,0,1)};
    public Color wantedColor;
    Color[] colors2 = { new Color(.5f,.5f,.5f,1), new Color(0f,0f,1f,1), new Color(1,0.92f,0.016f,1)};
    public Color Ui;

    public Sprite wantedSprite;    
    public Sprite[] spritesOP = {};

    public void WantedColor()
    {
        int newColor = Random.Range(0, colors1.Length);
        wantedColor = colors1[newColor];
        Ui = colors2[newColor];
        
        int spriteNumber = Random.Range(0, colors1.Length);
        wantedSprite = spritesOP[spriteNumber];
    }
}
