using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(TargetHolder))]
public class TargetByTag : MonoBehaviour
{
    [SerializeField]
    private string _tag = "Player";

    void Start()
    {
        var gmObj = GameObject.FindWithTag(_tag);
        if (gmObj != null)
            GetComponent<TargetHolder>().Target = gmObj;
        else
            Debug.LogError("Unable to find GameObject with tag: " + _tag);
    }
}
