using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    [SerializeField]
    private float _speed;
    [SerializeField]
    private TargetHolder _targetHolder;

    void Update()
    {
        Vector2 xy = Vector2.Lerp(
            transform.position,
            _targetHolder.Target.transform.position,
            _speed * Time.deltaTime
            );

        float z = transform.position.z;
        transform.position = new Vector3(xy.x, xy.y, z);
    }
}
