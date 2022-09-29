using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockRotation : MonoBehaviour
{
    private Quaternion _rotation;

    void Start()
    {
        _rotation = transform.rotation;
    }

    private void Update()
    {
        transform.rotation = _rotation;
    }
}
