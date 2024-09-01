using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public bool hasEnemy;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        hasEnemy = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        hasEnemy = false;
    }


}
