using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(TargetHolder))]
public class TargetRangeNotifier : MonoBehaviour
{
    [SerializeField]
    [Min(0f)]
    private float _range;
    [SerializeField]
    private UnityEvent _rangeEntered;
    [SerializeField]
    private UnityEvent _rangeExited;
    private TargetHolder _holder;

    private bool _inRange;

    private void Start()
    {
        _holder = GetComponent<TargetHolder>();
        _inRange = _range <= Vector2.Distance
            (transform.position, _holder.Target.transform.position);
    }

    void Update()
    {
        float distance = Vector2.Distance
            (transform.position, _holder.Target.transform.position);

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
