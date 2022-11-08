using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorVectorSetter : MonoBehaviour
{
    [SerializeField]
    private Animator _animator;
    [SerializeField]
    private string _nameX = "DirectionX";
    [SerializeField]
    private string _nameY = "DirectionY";

    public void UpdateDirection(Vector2 dir)
    {
        if (!gameObject.activeInHierarchy || dir == Vector2.zero)
            return;

        _animator.SetFloat(_nameX, dir.x);
        _animator.SetFloat(_nameY, dir.y);
    }
}
