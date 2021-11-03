using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MenuManager : MonoBehaviour
{
    public TextMeshProUGUI stateText;

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
        stateText.text = state.ToString();
    }
}
