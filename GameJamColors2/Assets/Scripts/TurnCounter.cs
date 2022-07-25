using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class TurnCounter : MonoBehaviour
{
    public IntData turnCount;
    public int checkpoint = 8;
    public UnityEvent turnStart;
    public Text scoreBoard;
    public Text finalScore;
    public Image uiColor;
    public TargetData targetColor;
    public Animator pterry;

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
        finalScore.text = scoreBoard.text;
        if (turnCount.value >= checkpoint)
        {
            if (checkpoint >= 15 && checkpoint < 30)
            {
                pterry.SetTrigger("NotChecked");
                checkpoint += 5;
                turnStart.Invoke();
                uiColor.color = targetColor.Ui;
                uiColor.sprite = targetColor.wantedSprite;
            }
            else if (checkpoint >= 30)
            {
                pterry.SetTrigger("CheckPoint");
                checkpoint += 3;
                turnStart.Invoke();
                uiColor.color = targetColor.Ui;
                uiColor.sprite = targetColor.wantedSprite;
            }
            else
            {
                pterry.SetTrigger("CheckPoint");
                checkpoint += 8;
                turnStart.Invoke();
                uiColor.color = targetColor.Ui;
                uiColor.sprite = targetColor.wantedSprite;   
            }
        }

        if (checkpoint >= 50)
        {
            pterry.SetTrigger("NotChecked");
        }
    }
}
