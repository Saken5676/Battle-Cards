using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class _GridManager : MonoBehaviour
{
    public int width;
    public int height;
    [SerializeField] private GameObject tilePrefab;
    private TileSpawner tileSpawner = new TileSpawner();





    private void Start()
    {
        //Generating tile grid based upon the desired width and height
        tileSpawner.GenerateGrid(tilePrefab, width, height);
        EventManager.instance.GridSpawnComplete();
    }

}
