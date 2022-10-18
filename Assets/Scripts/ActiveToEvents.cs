using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ActiveToEvents : MonoBehaviour
{
    [SerializeField]
    private UnityEvent _onEnable;
    [SerializeField]
    private UnityEvent _onDisable;

    private void OnEnable()
    {
        _onEnable?.Invoke();
    }

    void OnDisable()
    {
        _onDisable?.Invoke();
    }
}
