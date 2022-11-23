using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeroTransform : MonoBehaviour
{
    [SerializeField]
    private Transform _transform;

    public void ZeroTarget()
    {
        _transform.SetPositionAndRotation(
            Vector3.zero,
            Quaternion.identity
            );
    }
}
