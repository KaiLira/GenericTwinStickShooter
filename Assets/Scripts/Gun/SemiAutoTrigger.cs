using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SemiAutoTrigger : Trigger
{
    [SerializeField]
    private UnityEvent _fire;

    public override void TriggerPressed()
    {
        _fire?.Invoke();
    }
}
