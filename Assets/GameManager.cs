using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public static event Action<GameState> OnStateChanged;

    public GameState State;
    public enum GameState
    {
        Start,
        Prepare,
        Ready,
        End
    }

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        UpdateState(GameState.Start);
    }
    public void UpdateState(GameState newState)
    {
        State = newState;

        switch (newState)
        {
            case GameState.Start:
                HandleStart();
                break;
            case GameState.Prepare:
                HandlePrepare();
                break;
            case GameState.Ready:
                HandleReady();
                break;
            case GameState.End:
                HandleEnd();
                break;
        }
        OnStateChanged?.Invoke(newState);
        // print(newState);
    }

    private void HandleStart()
    {
        // play start animation, when we done, go to PREPARE
        Debug.Log("Start");
        UpdateState(GameState.Prepare);
    }

    private void HandlePrepare()
    {
        // do something
        Debug.Log("Preparing");
    }
    private void HandleReady()
    {
        // do something
        Debug.Log("Ready");
    }

    private void HandleEnd()
    {
        // play end animation or something
        Debug.Log("End");
    }
}
