using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] private bool _repeat = false;
    [SerializeField] private bool _running = false;
    [SerializeField] private UnityEvent _callback;
    private float _time = 0;

    void Update()
    {
        if (_running)
        {
            _time += Time.deltaTime;
            if (_time >= _duration)
            {
                _callback?.Invoke();

                if (_repeat)
                    _time = 0;
                else
                {
                    _time = 0;
                    _running = false;
                }
            }
        }
    }
}
