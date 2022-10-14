using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventToStateChange : MonoBehaviour
{
    [SerializeField]
    private GameObject state;
    [SerializeField]
    private GameObject _stateMachine;
    private StateMachine _fsm;

    void Start()
    {
        _fsm = _stateMachine.GetComponent<StateMachine>();
    }

    public void ChangeState()
    {
        if (state == null)
            _fsm.PopState();
        else
            _fsm.PushState(state);
    }
}
