using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObjectTowardsTarget : MonoBehaviour
{
    [SerializeField]
    private Transform _object;
    [SerializeField]
    private float _turnRate;
    [SerializeField]
    private TargetHolder _targetHolder;

    void Update()
    {
        Vector2 posObj = _object.position;
        Vector2 posTarget = _targetHolder.Target.transform.position;
        float angle = Utils.Angle(posObj, posTarget);

        _object.rotation = Quaternion.Lerp(
            transform.rotation,
            Utils.Rotation(angle),
            _turnRate * Time.deltaTime
        );
    }
}
