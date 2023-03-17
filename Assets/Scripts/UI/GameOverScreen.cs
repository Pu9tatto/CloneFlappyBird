using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameOverScreen : Screen
{
    public event UnityAction RestartButtonClick;
    public override void Close()
    {
        CanvasGroup.alpha = 0f;
        Button.interactable = false;
    }

    public override void Open()
    {
        CanvasGroup.alpha = 1.0f;
        Button.interactable = true;
    }

    protected override void OnButtonClick()
    {
        RestartButtonClick?.Invoke();
    }
}

