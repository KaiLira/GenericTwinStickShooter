using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateChanger : MonoBehaviour
{
    [System.Serializable]
    public enum ChangeType
    {
        SetState = 0,
        PushState = 1,
        PopStates = 2,
    }

    [SerializeField]
    private StateMachine _stateMachine;
    [SerializeField]
    private GameObject _state;
    [SerializeField]
    private ChangeType _changeType = ChangeType.SetState;
    [SerializeField, Min(1)]
    private int _popCount = 1;

    public void ChangeState()
    {
        switch (_changeType)
        {
            case ChangeType.PushState:
                _stateMachine.PushState(_state);
                break;
            case ChangeType.PopStates:
                _stateMachine.PopStates(_popCount);
                break;
            case ChangeType.SetState:
                _stateMachine.SetState(_state);
                break;
        }
    }
}
