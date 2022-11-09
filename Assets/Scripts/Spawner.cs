using System.Diagnostics.CodeAnalysis;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField, DisallowNull]
    private GameObject _prefab;
    [SerializeField]
    private bool _randomizePosition = false;
    [SerializeField]
    private Vector2 _maxOffset;
    private Pool _pool;

    [SerializeField]
    private bool _randomizeAngle = false;
    [SerializeField]
    [Range(0, 180)]
    private float _angle;

    void Start()
    {
        var pools = FindObjectsOfType<Pool>();
        foreach (var pool in pools)
        {
            if (_prefab.name == pool.Prefab.name)
            {
                _pool = pool;
                return;
            }
        }

        Debug.LogError("Pool not found for " + _prefab);
    }

    public void Spawn()
    {
        SpawnWithPosition(transform.position);
    }

    public void SpawnWithPosition(Vector2 pos)
    {
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
