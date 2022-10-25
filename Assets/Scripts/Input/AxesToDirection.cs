using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class AxesToDirection : MonoBehaviour
{
    [SerializeField]
    private string _horizontal = "Horizontal";
    [SerializeField]
    private string _vertical = "Vertical";
    [SerializeField]
    private DirectionHolder _directionHolder;


    void Update()
    {
        Vector2 direction = new
            (Input.GetAxis(_horizontal), Input.GetAxis(_vertical));
        _directionHolder.Direction = direction;
    }
}
