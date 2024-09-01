using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    //[SerializeField] private int health;
    public MouseController mouseController;
    private bool canMove = true;

/*    private void CheckTileForEnemy()
    {
        //checking if the tile has an enemy
        if (mouseController.selectedTile.GetComponent<Tile>().hasEnemy)
        {
            Debug.Log("Can't move here");
            //enemy selected event?
        }
        else
        {
            Move();
        }
    }

    private void Move() //Called after CheckTile
    {
        if (canMove)
        {
            Vector3 moveLocation = mouseController.selectedTile.transform.position;

            transform.position = moveLocation;
            canMove = false;
        }
    }*/


    private void GameManagerOnGameStateChanged(GameState state)
    {
        if (state == GameState.PlayerTurn)
        {
            canMove = true;
        }
    }

    //================================================
    //Event subscriptions
    private void OnEnable()
    {
        GameManager.OnGameStateChanged += GameManagerOnGameStateChanged;
        //mouseController.ObjectSelected += CheckTileForEnemy;
    }



    private void OnDisable()
    {
        GameManager.OnGameStateChanged -= GameManagerOnGameStateChanged;
        //mouseController.ObjectSelected -= CheckTileForEnemy;
    }


}
