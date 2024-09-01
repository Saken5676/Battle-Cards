using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GridManager : MonoBehaviour
{
    public int width;
    public int height;
    [SerializeField] private GameObject tilePrefab;
    private TileSpawner tileSpawner = new TileSpawner();
    [SerializeField] CameraController cameraController;


    private void Start()
    {
        //Generating tile grid based upon the desired width and height
        tileSpawner.GenerateGrid(tilePrefab, width, height);
        //Sets camera to center of grid
        cameraController.SetCamera(width, height);
    }

}
