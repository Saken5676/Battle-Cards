using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.U2D.Path.GUIFramework;
using UnityEngine;
using UnityEngine.EventSystems;


public class CameraController : MonoBehaviour
{
    [SerializeField] private Camera mainCam;


    //Camera Zoom Variables
    private float zoom;
    private float zoomMultiplier = 4f;
    private float minZoom = 4f;
    private float maxZoom = 8f;
    private float velocity = 0f;
    private float smoothTime = .25f;
  
    //Camera Pan Variables
    private Vector3 mouseWorldPosStart;

    private void Start()
    {
        zoom = mainCam.orthographicSize;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(2))
        {
            //When the button is first pushed it sets origin point then uses that in Pan Camera method
            mouseWorldPosStart = mainCam.ScreenToWorldPoint(Input.mousePosition);

        }
        if (Input.GetMouseButton(2))
        {
            PanCamera();
        }

        //Scrolling features
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        zoom -= scroll * zoomMultiplier;
        zoom = Mathf.Clamp(zoom, minZoom, maxZoom);
        mainCam.orthographicSize = Mathf.SmoothDamp(mainCam.orthographicSize, zoom, ref velocity, smoothTime);

    }

    //Sets Camera to center of generated grid
    public void SetCamera(int width, int height)
    {
        mainCam.transform.position = new Vector3((float)width / 2 - 0.5f, (float)height / 2 - 0.5f, -10f);
    }


    private void PanCamera()
    {
        if (Input.GetAxis("Mouse Y") != 0 || Input.GetAxis("Mouse X") != 0)
        {
            Vector3 mouseWorldPosDiff = mouseWorldPosStart - mainCam.ScreenToWorldPoint(Input.mousePosition);

            mainCam.transform.position += mouseWorldPosDiff;
        }

    }
}
