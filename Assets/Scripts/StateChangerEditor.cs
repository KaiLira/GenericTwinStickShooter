using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using Unity.VisualScripting;

[CustomEditor(typeof(StateChanger))]
public class StateChangerEditor : Editor
{
    SerializedProperty _stateMachine;
    SerializedProperty _state;
    SerializedProperty _changeType;
    SerializedProperty _popCount;

    public void OnEnable()
    {
        _stateMachine = serializedObject.FindPropertyOrFail("_stateMachine");
        _state = serializedObject.FindPropertyOrFail("_state");
        _changeType = serializedObject.FindPropertyOrFail("_changeType");
        _popCount = serializedObject.FindPropertyOrFail("_popCount");
    }

    public override void OnInspectorGUI()
    {
        // _stateMachine
        _stateMachine.objectReferenceValue = EditorGUILayout.ObjectField(
            "State Machine",
            _stateMachine.objectReferenceValue,
            typeof(StateMachine), true
        ) as StateMachine;

        // _changeType
        _changeType.enumValueIndex = (int) (StateChanger.ChangeType)
            EditorGUILayout.EnumPopup(
            "Change Type",
            (StateChanger.ChangeType) _changeType.enumValueIndex
        );

        // _state
        if (
            (StateChanger.ChangeType) _changeType.enumValueIndex !=
            StateChanger.ChangeType.PopStates
        )
            EditorGUILayout.ObjectField(_state);
        else
            _popCount.intValue = EditorGUILayout.IntField("Pop Count", _popCount.intValue);

        serializedObject.ApplyModifiedProperties();
    }
}
