using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;

public class LerpToObject : MonoBehaviour
{
    [SerializeField, DisallowNull]
    private Transform _target;
    [SerializeField, Min(0f)]
    private float _speed;

    void Update()
    {
        Vector2 xy = Vector2.Lerp(
            transform.position,
            _target.position,
            _speed * Time.deltaTime
            );

        transform.position = new(xy.x, xy.y, transform.position.z);
    }
}
