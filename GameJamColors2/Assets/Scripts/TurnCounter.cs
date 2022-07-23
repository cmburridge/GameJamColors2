using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class TurnCounter : MonoBehaviour
{
    public IntData turnCount;
    public int checkpoint = 1;
    public UnityEvent turnStart;
    public Text scoreBoard;
    public Image uiColor;
    public TargetData targetColor;

    public IntData health;

    private void Start()
    {
        turnCount.value = 0;
        health.value = 3;
        turnStart.Invoke();
        turnStart.Invoke();
        uiColor.color = targetColor.Ui;
        uiColor.color = targetColor.Ui;
        uiColor.sprite = targetColor.wantedSprite;
    }

    private void Update()
    {
        scoreBoard.text = turnCount.value.ToString();
        if (turnCount.value >= checkpoint)
        {
            if (checkpoint >= 5 && checkpoint < 10)
            {
                checkpoint += 2;
                turnStart.Invoke();
                uiColor.color = targetColor.Ui;
                uiColor.sprite = targetColor.wantedSprite;
            }
            else if (checkpoint >= 10)
            {
                checkpoint += 3;
                turnStart.Invoke();
                uiColor.color = targetColor.Ui;
                uiColor.sprite = targetColor.wantedSprite;
            }
            else
            {
                checkpoint += 1;
                turnStart.Invoke();
                uiColor.color = targetColor.Ui;
                uiColor.sprite = targetColor.wantedSprite;   
            }
        }
    }
}
