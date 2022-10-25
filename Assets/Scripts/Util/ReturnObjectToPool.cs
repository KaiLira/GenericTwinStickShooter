using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;

public class ReturnObjectToPool : MonoBehaviour
{
    [SerializeField, DisallowNull]
    private GameObject _target;
    private Pool _pool;

    void Start()
    {
        _pool = _target.GetComponentInParent<Pool>();
        if (_pool == null)
            Debug.LogError(_target.name + "is not part of a pool");
    }

    public void ReturnTarget()
    {
        int id = _target.transform.GetSiblingIndex();
        _pool.Return(id);
    }
}
