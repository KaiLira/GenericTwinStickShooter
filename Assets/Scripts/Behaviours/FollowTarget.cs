using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    [SerializeField]
    private Transform _target;
    [SerializeField]
    private float _speed;

    void Update()
    {
        Vector2 xy = Vector2.Lerp(transform.position, _target.position, _speed * Time.deltaTime);
        float z = transform.position.z;
        transform.position = new Vector3(xy.x, xy.y, z);
    }
}
