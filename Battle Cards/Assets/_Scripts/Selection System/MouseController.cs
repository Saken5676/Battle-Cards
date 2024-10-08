using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class MouseController : MonoBehaviour
{
    public InputActionReference select;
    public Camera mainCam;
    public GameObject SelectedItem;

    private void Update()
    {
        
    }


    private void CollisionCheck(InputAction.CallbackContext context)
    {
        //checking is the cursor is hovering over UI and not casting if so. 
        bool isOverUi = UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject();
        if (isOverUi)
        {
            
            Debug.Log("Clicked on UI");
            return;
        }
        RaycastHit2D rayHit;
        rayHit = Physics2D.GetRayIntersection(mainCam.ScreenPointToRay(Mouse.current.position.ReadValue()));
        if (!rayHit.collider)
        {
            return;
        }
        else
        {
            SelectedItem = rayHit.collider.gameObject;
            EventManager.instance.ItemSelected();
        }
    }



    //==================================================
    //Event subscriptions
    private void OnEnable()
    {
        select.action.started += CollisionCheck;
    }
    private void OnDisable()
    {
        select.action.started -= CollisionCheck;
    }

}
