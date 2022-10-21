using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Spawner))]
public class SpawnerEditor : Editor
{
    SerializedProperty _pool;

    SerializedProperty _randomizePosition;
    SerializedProperty _maxOffset;

    SerializedProperty _randomizeAngle;
    SerializedProperty _angle;

    public void OnEnable()
    {

        _pool = serializedObject.FindPropertyOrFail("_pool");
        _randomizePosition = serializedObject.FindPropertyOrFail("_randomizePosition");
        _maxOffset = serializedObject.FindPropertyOrFail("_maxOffset");
        _randomizeAngle = serializedObject.FindPropertyOrFail("_randomizeAngle");
        _angle = serializedObject.FindPropertyOrFail("_angle");
    }

    public override void OnInspectorGUI()
    {
        EditorGUILayout.ObjectField(_pool);

        EditorGUILayout.Space();

        _randomizePosition.boolValue = EditorGUILayout.Toggle(
            "Randomize Position",
            _randomizePosition.boolValue
            );

        if (_randomizePosition.boolValue)
        {
            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.Space();
            _maxOffset.vector2Value = EditorGUILayout.Vector2Field
                ("", _maxOffset.vector2Value * 2f) * 0.5f;
            EditorGUILayout.EndHorizontal();
        }

        EditorGUILayout.Space();

        _randomizeAngle.boolValue = EditorGUILayout.Toggle(
            "Randomize Angle",
            _randomizeAngle.boolValue
            );

        if (_randomizeAngle.boolValue)
            _angle.floatValue = EditorGUILayout.Slider(
                "Angle",
                _angle.floatValue * 2,
                0f,
                360f
                ) * 0.5f;

        serializedObject.ApplyModifiedProperties();
    }
}
