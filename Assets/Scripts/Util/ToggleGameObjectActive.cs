using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleGameObjectActive : MonoBehaviour
{
    [SerializeField]
    private GameObject _target;

    public void ToggleTarget()
    {
        _target.SetActive(!_target.activeInHierarchy);
    }
}
