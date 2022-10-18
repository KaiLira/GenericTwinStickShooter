using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TargetRangeNotifier : MonoBehaviour
{
    [SerializeField]
    [Min(0f)]
    private float _range;
    [SerializeField]
    private UnityEvent _rangeEntered;
    [SerializeField]
    private UnityEvent _rangeExited;
    [SerializeField]
    private TargetHolder _targetHolder;

    private bool _inRange;

    private void Start()
    {
        _inRange = _range <= Vector2.Distance
            (transform.position, _targetHolder.Target.transform.position);
    }

    void Update()
    {
        float distance = Vector2.Distance
            (transform.position, _targetHolder.Target.transform.position);

        if (_inRange && distance > _range)
        {
            _inRange = false;
            _rangeExited?.Invoke();
        }
        else if (!_inRange && distance <= _range)
        {
            _rangeEntered?.Invoke();
            _inRange = true;
        }
    }
}
