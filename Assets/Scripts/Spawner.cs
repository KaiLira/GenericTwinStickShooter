using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.SearchService;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject _gameObject;
    [SerializeField]
    private Transform _transform;

    [SerializeField]
    private bool _randomizePosition = false;
    [SerializeField]
    private float _positionX, _positionY;

    [SerializeField]
    private bool _randomizeAngle = false;
    [SerializeField]
    [Range(0, 180)]
    private float _angle;


    public void Spawn()
    {
        Vector3 pos = _transform.position;
        Quaternion rot = _transform.rotation;

        if (_randomizePosition)
        {
            pos.x += Random.Range(-_positionX, _positionX);
            pos.y += Random.Range(-_positionY, _positionY);
        }

        if (_randomizeAngle)
            rot.eulerAngles = rot.eulerAngles +
                              new Vector3(
                                  0, 0,
                                  Random.Range(-_angle, _angle)
                              );

        GameObject.Instantiate(_gameObject, pos, rot);
    }
}
