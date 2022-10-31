using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DirectionHolder : MonoBehaviour
{
    [SerializeField]
    private Vector2 _direction;
    [SerializeField]
    private UnityEvent<Vector2> _directionChanged;

    public Vector2 Direction
    {
        get => _direction;

        set
        {
            _direction = Vector2.ClampMagnitude(value, 1);
            _directionChanged?.Invoke(_direction);
        }
    }
}
