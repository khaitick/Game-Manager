using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prepare : MonoBehaviour
{
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
        if (state != GameManager.GameState.Prepare) return;

        // do something, after we done, go to Ready
        GameManager.Instance.UpdateState(GameManager.GameState.Ready);

    }
}
