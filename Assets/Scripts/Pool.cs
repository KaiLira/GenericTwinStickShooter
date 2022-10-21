using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using UnityEditorInternal;
using UnityEngine;

public class Pool : MonoBehaviour
{
    [SerializeField, DisallowNull]
    private GameObject _prefab;
    [SerializeField]
    private int _objectCount;
    private Stack<int> _inactives = new();

    void Start()
    {
        _inactives = new();
        int childCount = transform.childCount;
        for (int i = 0; i < childCount; i++)
        {
            DestroyImmediate(transform.GetChild(0).gameObject);
        }

        for (int i = 0; i < _objectCount; i++)
        {
            Instantiate(_prefab, transform);
            transform.GetChild(i).gameObject.SetActive(false);
            _inactives.Push(i);
        }
    }

    public int Spawn(Vector3 pos, Quaternion rot)
    {
        int id = _inactives.Pop();
        GameObject instance = transform.GetChild(id).gameObject;
        instance.transform.SetPositionAndRotation(pos, rot);
        instance.SetActive(true);
        return id;
    }
}
