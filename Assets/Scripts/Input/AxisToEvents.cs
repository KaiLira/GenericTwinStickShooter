using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AxisToEvents : MonoBehaviour
{
    [SerializeField]
    private string _axisName;
    [SerializeField]
    private UnityEvent _onDown;
    [SerializeField]
    private UnityEvent _onUp;
    private bool _down = false;

    void Update()
    {
        if (!_down && Input.GetAxis(_axisName) != 0f)
        {
            _onDown?.Invoke();
            _down = true;
        }
        else if (_down && Input.GetAxis(_axisName) == 0f)
        {
            _onUp?.Invoke();
            _down = false;
        }
    }
}
