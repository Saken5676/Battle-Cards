using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTurnButton : MonoBehaviour
{
    public void EndPlayerTurn()
    {
        Debug.Log("Player Turn Ended");
        GameManager.Instance.UpdateGameState(GameState.EnemyTurn);
    }
}
