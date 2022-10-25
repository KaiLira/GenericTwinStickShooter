using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslateObjectInDirection : MonoBehaviour
{
    [SerializeField]
    private Transform _object;
    [SerializeField]
    private float _speed;
    [SerializeField]
    private DirectionHolder _directionHolder;

    void Update()
    {
        _object.Translate(_speed * Time.deltaTime * _directionHolder.Direction);
    }
}
