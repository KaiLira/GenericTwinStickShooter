using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ChangeDirectionWithInput : MonoBehaviour
{
    [SerializeField]
    private DirectionHolder _directionHolder;
    private Vector2 _dirBuffer = Vector2.zero;

    public void UpdateDirection(InputAction.CallbackContext context)
    {
        var direction = context.ReadValue<Vector2>();

        _dirBuffer = direction;
        if (gameObject.activeInHierarchy)
            _directionHolder.Direction = direction;
    }

    void OnEnable()
    {
        _directionHolder.Direction = _dirBuffer;
    }
}
