using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformCopy : MonoBehaviour
{
    [SerializeField]
    private Transform _source;
    [SerializeField]
    private Transform _target;

    public void CopyTransform()
    {
        _target.SetPositionAndRotation(
            _source.position,
            _source.rotation
            );
    }
}
