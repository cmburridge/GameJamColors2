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

    public IntData eaten;

    private void Start()
    {
        turnStart.Invoke();
        turnStart.Invoke();
        uiColor.color = targetColor.Ui;
        uiColor.color = targetColor.Ui;
    }

    private void Update()
    {
        scoreBoard.text = turnCount.value.ToString();
        if (turnCount.value > checkpoint)
        {
            eaten.value = 0;
            checkpoint += 3;
            turnStart.Invoke();
            uiColor.color = targetColor.Ui;
        }
    }
}
