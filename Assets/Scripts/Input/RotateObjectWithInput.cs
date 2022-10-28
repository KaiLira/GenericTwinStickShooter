using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class RotateObjectWithInput : MonoBehaviour
{
    [SerializeField]
    private Transform _object;
    private float prevAngle = 0f;

    public void ControllerLookInput(InputAction.CallbackContext ctx)
    {
        float angle = prevAngle;
        var direction = ctx.ReadValue<Vector2>();
        if (direction != Vector2.zero)
        {
            angle = -Vector2.SignedAngle(direction, Vector2.right);
            prevAngle = angle;
        }

        _object.rotation = Utils.Rotation(angle);
    }

    public void MouseLookInput(InputAction.CallbackContext ctx)
    {
        Vector2 position = ctx.ReadValue<Vector2>();
        position = Camera.main.ScreenToWorldPoint(position);
        position -= (Vector2) _object.position;

        _object.rotation = Utils.Rotation
            (- Vector2.SignedAngle(position, Vector2.right));
    }    
}
