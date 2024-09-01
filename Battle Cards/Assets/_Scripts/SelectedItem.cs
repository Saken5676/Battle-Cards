using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectedItem : MonoBehaviour
{
    public static SelectedItem Instance;
    public GameObject selectedGameObject;
    public MouseController mouseController;

    public event Action TileSelected;
    public event Action UnitSelected;

    private void Awake()
    {
        Instance = this;
    }
    private void CheckTileForObjectType()
    {
        //determine what is selected and then pass the gameobject to that script
        if (selectedGameObject.TryGetComponent<Tile>(out Tile tile))
        {
            //A tile is selected
            //Invoke event and pass gameobject
            Debug.Log("Tile Selected");
        }
        if (selectedGameObject.TryGetComponent<Enemy>(out Enemy enemy))
        {
            //An enemy is selected
            //Invoke event and pass gameobject
            Debug.Log("Enemy Selected");
        }
    }    
    
    
    
    //=======================================================
    //Event Subscriptions
    private void OnEnable()
    {
        mouseController.ObjectSelected += CheckTileForObjectType;
    }



    private void OnDisable()
    {
        mouseController.ObjectSelected -= CheckTileForObjectType;
    }
}
