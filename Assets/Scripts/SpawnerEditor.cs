using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Spawner))]
public class SpawnerEditor : Editor
{
    SerializedProperty _gameObject;
    SerializedProperty _transform;

    SerializedProperty _randomizePosition;
    SerializedProperty _positionX;
    SerializedProperty _positionY;

    SerializedProperty _randomizeAngle;
    SerializedProperty _angle;

    public void OnEnable()
    {

        _gameObject = serializedObject.FindPropertyOrFail("_gameObject");
        _transform = serializedObject.FindPropertyOrFail("_transform");
        _randomizePosition = serializedObject.FindPropertyOrFail("_randomizePosition");
        _positionX = serializedObject.FindPropertyOrFail("_positionX");
        _positionY = serializedObject.FindPropertyOrFail("_positionY");
        _randomizeAngle = serializedObject.FindPropertyOrFail("_randomizeAngle");
        _angle = serializedObject.FindPropertyOrFail("_angle");
    }

    public override void OnInspectorGUI()
    {
        EditorGUILayout.ObjectField(_gameObject);
        EditorGUILayout.PropertyField(_transform);

        EditorGUILayout.Space();

        _randomizePosition.boolValue = EditorGUILayout.Toggle(
            "Randomize Position",
            _randomizePosition.boolValue
            );
        if (_randomizePosition.boolValue)
        {
            var bar = EditorGUILayout.Vector2Field
                ("", new Vector2(_positionX.floatValue, _positionY.floatValue));

            _positionX.floatValue = bar.x;
            _positionY.floatValue = bar.y;
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
