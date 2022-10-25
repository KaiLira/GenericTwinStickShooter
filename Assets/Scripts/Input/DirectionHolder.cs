using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionHolder : MonoBehaviour
{
    [SerializeField]
    private Vector2 _diection;

    public Vector2 Direction
    {
        get => _diection;

        set
        {
            if (value.sqrMagnitude > 1)
                _diection = value.normalized;
            else
                _diection = value;
        }
    }
}
