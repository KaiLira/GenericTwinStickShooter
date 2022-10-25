using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
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
        if (!_inactives.TryPop(out int id))
            return -1;

        Transform instance = transform.GetChild(id);
        instance.SetPositionAndRotation(pos, rot);
        instance.gameObject.SetActive(true);
        return id;
    }

    public void Return(int id)
    {
        transform.GetChild(id).gameObject.SetActive(false);
        _inactives.Push(id);
    }
}