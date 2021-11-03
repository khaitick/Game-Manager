using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ready : MonoBehaviour
{
    public Button endButton;
    public bool allowSomething;
    private void OnEnable()
    {
        GameManager.OnStateChanged += OnStateChanged;
    }

    private void OnDisable()
    {
        GameManager.OnStateChanged -= OnStateChanged;
    }

    private void OnStateChanged(GameManager.GameState state)
    {
        allowSomething = (state == GameManager.GameState.Ready);  // should be TRUE when the state is READY
    }
    public void onClickEndButton()
    {
        if (allowSomething)
        {
            GameManager.Instance.UpdateState(GameManager.GameState.End);
        }
    }
}
