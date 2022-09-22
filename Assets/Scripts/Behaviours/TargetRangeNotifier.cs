using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TargetRangeNotifier : MonoBehaviour
{
    [SerializeField]
    private Transform target;
    [SerializeField]
    [Min(0f)]
    private float _range;
    [SerializeField]
    private UnityEvent _rangeEntered;
    [SerializeField]
    private UnityEvent _rangeExited;

    private bool _inRange = false;

    void Update()
    {
        float distance = Vector2.Distance(transform.position, target.position);

        if (_inRange && distance > _range)
            _rangeExited?.Invoke();
        else if (!_inRange && distance <= _range)
            _rangeEntered?.Invoke();
    }
}
