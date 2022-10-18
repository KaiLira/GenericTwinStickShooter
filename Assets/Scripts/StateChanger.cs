using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateChanger : MonoBehaviour
{
    [System.Serializable]
    public enum ChangeType
    {
        SetState,
        PushState,
        PopState,
    }

    [SerializeField]
    private GameObject _stateMachine;
    [SerializeField]
    private GameObject state;
    [SerializeField]
    private ChangeType _changeType = ChangeType.SetState;
    private StateMachine _fsm;

    void Start()
    {
        _fsm = _stateMachine.GetComponent<StateMachine>();
    }

    public void ChangeState()
    {
        switch (_changeType)
        {
            case ChangeType.PushState:
                _fsm.PushState(state);
                break;
            case ChangeType.PopState:
                _fsm.PopState();
                break;
            case ChangeType.SetState:
                _fsm.SetState(state);
                break;
        }
    }
}
