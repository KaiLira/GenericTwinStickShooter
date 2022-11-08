using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetAnimatorFloatToSpeed : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D _rigidBody;
    [SerializeField]
    private Animator _animator;
    [SerializeField]
    private string _floatName = "Speed";

    void Update()
    {
        _animator.SetFloat(_floatName, _rigidBody.velocity.magnitude);
    }
}
