using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForceInDirection : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D _body;
    [SerializeField]
    private DirectionHolder _directionHolder;
    [SerializeField, Min(0f)]
    private float _magnitude;
    [SerializeField, Min(0f)]
    private float _maxSpeed;

    void FixedUpdate()
    {
        if (_body.velocity.sqrMagnitude > _maxSpeed * _maxSpeed)
            _body.velocity = Vector2.ClampMagnitude(_body.velocity, _maxSpeed);
        else
            _body.AddForce(_directionHolder.Direction * _magnitude);
    }
}
