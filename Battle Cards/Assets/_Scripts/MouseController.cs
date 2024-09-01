using System;
using UnityEngine;
using UnityEngine.InputSystem;


public class MouseController : MonoBehaviour
{
    public InputActionReference select;
    public Camera mainCam;

    public event Action ObjectSelected;



    private void CollisionCheck(InputAction.CallbackContext context)
    {
        //checking is the cursor is hovering over UI and not casting if so. 
        bool isOverUi = UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject();
        if (isOverUi)
        {
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
            SelectedItem.Instance.selectedGameObject = rayHit.collider.gameObject;
            ObjectSelected?.Invoke();
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
