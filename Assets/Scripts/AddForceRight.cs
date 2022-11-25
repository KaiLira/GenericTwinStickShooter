using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForceRight : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D _target;
    [SerializeField]
    private float _magnitude;

    public void AddForce()
    {
        _target.AddForce(
            Utils.VecFromComponents(
                _magnitude,
                transform.rotation.eulerAngles.z
            ));
    }
}
