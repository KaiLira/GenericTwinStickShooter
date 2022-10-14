using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(TargetHolder))]
public class RotateObjectTowardsTarget : MonoBehaviour
{
    [SerializeField]
    private Transform _object;
    [SerializeField]
    private float _turnRate;
    private TargetHolder _holder;

    private void Start()
    {
        _holder = GetComponent<TargetHolder>();
    }

    void Update()
    {
        Vector2 posObj = _object.position;
        Vector2 posTarget = _holder.Target.transform.position;
        float angle = Utils.Angle(posObj, posTarget);

        _object.rotation = Quaternion.Lerp(
            transform.rotation,
            Utils.Rotation(angle),
            _turnRate * Time.deltaTime
        );
    }
}
