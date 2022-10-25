using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Timer))]
public class BranchTimerRunning : MonoBehaviour
{
    [SerializeField]
    private UnityEvent _true;
    [SerializeField]
    private UnityEvent _false;
    private Timer _timer;

    void Start()
    {
        _timer = GetComponent<Timer>();
    }

    public void Banch()
    {
        if (_timer.Running)
            _true?.Invoke();
        else
            _false?.Invoke();
    }
}
