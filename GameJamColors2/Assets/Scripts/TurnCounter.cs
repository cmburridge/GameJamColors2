using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class TurnCounter : MonoBehaviour
{
    public IntData turnCount;
    public int checkpoint = 3;
    public UnityEvent turnStart;
    public Text scoreBoard;
    public Image uiColor;
    public TargetData targetColor;

    private void Start()
    {
        turnStart.Invoke();
        turnStart.Invoke();
        uiColor.color = targetColor.wantedColor;
    }

    private void Update()
    {
        scoreBoard.text = turnCount.value.ToString();
        if (turnCount.value > checkpoint)
        {
            uiColor.color = targetColor.wantedColor;
            checkpoint += 3;
            turnStart.Invoke();
        }
    }
}
