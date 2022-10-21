using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Unity.VisualScripting;
using UnityEditor.SearchService;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField, DisallowNull]
    private Pool _pool;
    [SerializeField]
    private bool _randomizePosition = false;
    [SerializeField]
    private Vector2 _maxOffset;

    [SerializeField]
    private bool _randomizeAngle = false;
    [SerializeField]
    [Range(0, 180)]
    private float _angle;


    public void Spawn()
    {
        Vector3 pos = transform.position;
        Quaternion rot = transform.rotation;

        if (_randomizePosition)
        {
            pos.x += Random.Range(-_maxOffset.x, _maxOffset.x);
            pos.y += Random.Range(-_maxOffset.y, _maxOffset.y);
        }

        if (_randomizeAngle)
            rot.eulerAngles = rot.eulerAngles +
                              new Vector3(
                                  0, 0,
                                  Random.Range(-_angle, _angle)
                              );

        _pool.Spawn(pos, rot);
    }
}
