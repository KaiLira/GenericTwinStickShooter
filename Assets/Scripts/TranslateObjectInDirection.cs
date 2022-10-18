using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslateObjectInDirection : MonoBehaviour
{
    [SerializeField] private Transform _object;
    [SerializeField] private float _speed;
    [SerializeField] private Vector2 _direction = Vector2.right;

    void Start()
    {
        _direction = _direction.normalized;
    }

    void Update()
    {
        _object.Translate(_speed * Time.deltaTime * _direction);
    }
}
