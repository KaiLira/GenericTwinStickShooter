using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    [SerializeField] GameObject _target;

    void Start()
    {
        if (!_target)
            _target = gameObject;
    }

    public void DestroyTarget()
    {
        Destroy(_target);
    }
}
