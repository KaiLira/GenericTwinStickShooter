using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Multishot : MonoBehaviour
{
    [SerializeField]
    [Min(2)]
    private int _shotCount;
    private int _shotsFired = 0;
    [SerializeField]
    [Range(0f, 0.01f)]
    private float _maxShotDelay = 0f;
    private float _delayCounter = 0f;
    [SerializeField]
    private UnityEvent _fire;
    private bool _firing;

    public void Fire()
    {
        if (!_firing)
        {
            _firing = true;
            _shotsFired = 0;
            _delayCounter = 0f;
        }
    }

    void Update()
    {
        if (!_firing)
            return;

        if (_shotsFired >= _shotCount)
        {
            _firing = false;
            return;
        }

        if (_delayCounter > 0f)
        {
            _delayCounter -= Time.deltaTime;
            return;
        }

        _fire?.Invoke();
        _shotsFired++;
        _delayCounter = Random.Range(0, _maxShotDelay);
    }
}
