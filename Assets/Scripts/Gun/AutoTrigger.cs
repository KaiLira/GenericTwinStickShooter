using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AutoTrigger : MonoBehaviour
{
    [SerializeField] private float _fireDelay;
    [SerializeField] private UnityEvent _fire;
    private float _delayCounter = 0f;
    private bool _firing = false;

    public void TriggerPressed()
    {
        _firing = true;
    }

    public void TriggerReleased()
    {
        _firing = false;
    }

    void Update()
    {
        if (_delayCounter > 0f)
            _delayCounter -= Time.deltaTime;

        if (_firing)
        {
            if (_delayCounter <= 0f)
            {
                _fire?.Invoke();
                _delayCounter = _fireDelay;
            }
        }
    }
}
