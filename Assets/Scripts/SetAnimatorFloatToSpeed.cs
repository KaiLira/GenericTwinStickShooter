using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetAnimatorFloatToSpeed : MonoBehaviour
{
    [SerializeField]
    private Transform _object;
    [SerializeField]
    private Animator _animator;
    [SerializeField]
    private string _floatName = "MovementSpeed";
    private Vector2 _prevPos;

    private void Start()
    {
        _prevPos = _object.position;
    }

    void Update()
    {
        Vector2 pos = _object.position;
        float speed = (_prevPos - pos).magnitude / Time.deltaTime;
        _animator.SetFloat(_floatName, speed);
        _prevPos = pos;
    }
}
