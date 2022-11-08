using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyMinSpeed : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D _rigidBody;
    [SerializeField]
    private float _minSpeed;
    [SerializeField]
    private bool _setToZero = true;

    void Update()
    {
        if (_rigidBody.velocity.sqrMagnitude <= _minSpeed * _minSpeed)
            if (_setToZero)
                _rigidBody.velocity = Vector2.zero;
            else
                _rigidBody.velocity = _rigidBody.velocity.normalized * _minSpeed;
    }
}
