using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{
    [SerializeField]
    private float _duration;
    [SerializeField]
    private bool _repeat = false;
    [SerializeField]
    private bool _running = false;
    [SerializeField]
    private UnityEvent _callback;
    private float _time = 0;

    public bool Running
        { get => _running; }

    void Update()
    {
        if (_running)
        {
            _time += Time.deltaTime;
            if (_time >= _duration)
            {
                _callback?.Invoke();
                _time = 0;
                if (!_repeat)
                    _running = false;
            }
        }
    }

    public void StartTimer()
    {
        _time = 0;
        _running = true;
    }

    public void StopTimer()
    {
        _running = false;
    }

    public void ChangeTime(float percentage)
    {
        _duration *= 1 + (percentage / 100);
    }
}
