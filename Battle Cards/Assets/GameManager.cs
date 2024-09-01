using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
//I think the tile check needs to be in the manager and trigger other component based upon find
    public static GameManager Instance;

    public GameState State;

    public static event Action<GameState> OnGameStateChanged;


    private void Start()
    {
        //Turning off until ready to deploy
        //UpdateGameState(GameState.MainMenu);
    }
    private void Awake()
    {
        Instance = this;
    }

    public void UpdateGameState(GameState newState)
    {
        State = newState;

        switch (newState)
        {
            case GameState.MainMenu:
                //Add unique Logic here
                break;
            case GameState.PlayerTurn:
                //Add unique Logic here
                break;
            case GameState.EnemyTurn:
                //Add unique Logic here
                break;
            case GameState.Victory:
                //Add unique Logic here
                break;
            case GameState.Lose:
                //Add unique Logic here
                break;
        }
        OnGameStateChanged?.Invoke(newState);
    }
}

public enum GameState
{
    MainMenu,
    PlayerTurn,
    EnemyTurn,
    Victory,
    Lose
}
