using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HighlightTile : MonoBehaviour
{
    //This script activates a opaque gameobject when hovered
    
    [SerializeField] private GameObject highlight;
    private BoxCollider2D col;

    private void Start()
    {
        col = GetComponent<BoxCollider2D>();
    }
    private void OnMouseEnter()
    {
        highlight.SetActive(true);
    }

    private void OnMouseExit()
    {
        highlight.SetActive(false);
    }



}
