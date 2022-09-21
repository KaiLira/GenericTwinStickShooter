using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.SearchService;
using UnityEngine;

[System.Serializable]
public struct Position
{
    public float x;
    public float y;
}

public class Spawner : MonoBehaviour
{
    [Header("Settings")]
    [SerializeField]
    private GameObject _prefab;
    [SerializeField]
    private Transform _transform;

    [Space(15)]
    [Header("Randomization")]
    [SerializeField]
    private bool _randomizeAngle = false;
    [SerializeField]
    [Range(0, 360)]
    private float _angle;
    [SerializeField]
    private bool _randomizePosition = false;
    [SerializeField]
    private Position _position;

    public void Spawn()
    {
        Vector3 pos = _transform.position;
        Quaternion rot = _transform.rotation;

        if (_randomizePosition)
        {
            pos.x += Random.Range(-_position.x, _position.x);
            pos.y += Random.Range(-_position.y, _position.y);
        }

        if (_randomizeAngle)
            rot.eulerAngles = rot.eulerAngles +
                              new Vector3(
                                  0, 0,
                                  Random.Range(-_angle, _angle)
                              );

        GameObject.Instantiate(_prefab, pos, rot);
    }
}
