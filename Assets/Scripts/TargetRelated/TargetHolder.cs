using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetHolder : MonoBehaviour
{
    private GameObject _target;

    public GameObject Target
    {
        get { return _target; }
        set { _target = value; }
    }
}
