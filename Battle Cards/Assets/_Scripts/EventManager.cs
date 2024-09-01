using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    //Custom event system
    //All events should be added here
    //When making an event you need to add a public method that will allow the event manager to invoke the event
    //^this is done since you cannot invoke event from a class does that not own it

    //Singleton that allows access from everwhere
    public static EventManager instance;

    private void Awake()
    {
        instance = this;
    }
    public event Action OnGridSpawnComplete;
    public void GridSpawnComplete()
    {
        OnGridSpawnComplete?.Invoke();
    }

    public event Action OnItemSelected;
    public void ItemSelected()
    {
        OnItemSelected?.Invoke();
    }
}
