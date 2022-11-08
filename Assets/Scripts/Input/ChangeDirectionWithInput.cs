using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ChangeDirectionWithInput : MonoBehaviour
{
    [SerializeField]
    private DirectionHolder _directionHolder;

    public void UpdateDirection(InputAction.CallbackContext context)
    {
        if (gameObject.activeInHierarchy)
            _directionHolder.Direction = context.ReadValue<Vector2>();
    }
}
