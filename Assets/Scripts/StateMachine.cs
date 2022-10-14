using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    [SerializeField]
    private GameObject _defaultState;
    private Stack<GameObject> _states = new();

    void Start()
    {
        PushState(_defaultState);
    }

    public void PushState(GameObject state)
    {
        if (_states.TryPeek(out var last))
            last.SetActive(false);

        state.SetActive(true);
        _states.Push(state);
    }

    public void PopState()
    {
        var last = _states.Pop();
        last.SetActive(false);

        if (_states.TryPeek(out last))
            last.SetActive(true);
    }
}
