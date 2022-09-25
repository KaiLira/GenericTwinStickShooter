using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(TargetHolder))]
public class FollowTarget : MonoBehaviour
{
    [SerializeField]
    private float _speed;
    private TargetHolder _holder;

    private void Start()
    {
        _holder = GetComponent<TargetHolder>();
    }

    void Update()
    {
        Vector2 xy = Vector2.Lerp(
            transform.position,
            _holder.Target.transform.position,
            _speed * Time.deltaTime
            );

        float z = transform.position.z;
        transform.position = new Vector3(xy.x, xy.y, z);
    }
}
