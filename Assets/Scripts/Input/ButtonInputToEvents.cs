using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class ButtonInputToEvents : MonoBehaviour
{
    [SerializeField]
    private UnityEvent _buttonPressed;
    [SerializeField]
    private UnityEvent _buttonReleased;

    public void ProcessEvent(InputAction.CallbackContext ctx)
    {
        if (ctx.ReadValueAsButton())
            _buttonPressed?.Invoke();
        else
            _buttonReleased?.Invoke();
    }
}
