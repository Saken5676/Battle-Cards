using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _SelectionManager : MonoBehaviour
{
    public static _SelectionManager Instance;
    public MouseController mouseController;

    public GameObject selectedGameObject;


    private void Awake()
    {
        Instance = this;
    }

    private void CheckTileForObjectType()
    {
        selectedGameObject = mouseController.SelectedItem;
        //determine what is selected and then pass the gameobject to that script
        if (selectedGameObject.TryGetComponent<Tile>(out Tile tile))
        {
            Debug.Log(selectedGameObject.name);
        }
        if (selectedGameObject.TryGetComponent<Enemy>(out Enemy enemy))
        {
            Debug.Log(selectedGameObject.name);
        }
        if (selectedGameObject.TryGetComponent<Player>(out Player player))
        {
            Debug.Log(selectedGameObject.name);
        }
    }







    //==================================================
    //Event subscriptions
    private void OnEnable()
    {
        EventManager.instance.OnItemSelected += CheckTileForObjectType;
    }



    private void OnDisable()
    {
        EventManager.instance.OnItemSelected -= CheckTileForObjectType; 
    }

}
