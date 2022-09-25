using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(TargetHolder))]
public class RotateTowardsTarget : MonoBehaviour
{
    [SerializeField]
    private float _turnRate;
    private TargetHolder _holder;

    private void Start()
    {
        _holder = GetComponent<TargetHolder>();
    }

    void Update()
    {
        Vector2 posSelf = transform.position;
        Vector2 posTarget = _holder.Target.transform.position;
        float angle = Utils.Angle(posSelf, posTarget);

        transform.rotation = Quaternion.Lerp(
            transform.rotation,
            Utils.Rotation(angle),
            _turnRate * Time.deltaTime
            );
    }
}
