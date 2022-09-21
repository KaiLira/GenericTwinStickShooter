using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MoveWithAxes : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private string _horizontal = "Horizontal";
    [SerializeField] private string _vertical = "Vertical";

    void Update()
    {
        Vector3 direction = new (Input.GetAxis(_horizontal), Input.GetAxis(_vertical));
        if (direction.sqrMagnitude > 1)
            direction = direction.normalized;

        transform.position += direction * _speed * Time.deltaTime;
    }
}
