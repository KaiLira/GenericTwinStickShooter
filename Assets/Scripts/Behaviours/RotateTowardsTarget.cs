using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTowardsTarget : MonoBehaviour
{
    [SerializeField]
    private Transform _target;
    [SerializeField]
    private float _turnRate;

    void Update()
    {
        Vector2 posSelf = transform.position;
        Vector2 posTarget = _target.position;
        float angle = Utils.Angle(posSelf, posTarget);

        transform.rotation = Quaternion.Lerp(
            transform.rotation,
            Utils.Rotation(angle),
            _turnRate * Time.deltaTime
            );
    }
}
