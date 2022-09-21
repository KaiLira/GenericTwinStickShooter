using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;
using UnityEngine.Rendering;

public class ComponentController : MonoBehaviour
{
    private Dictionary<System.Type, bool> _behaviorList;

    public void EnableAndDisableComponents()
    {
        foreach (var pair in _behaviorList)
        {
            var behavior = GetComponent(pair.Key) as Behaviour;
            if (behavior != null)
                behavior.enabled = pair.Value;
            else
                Debug.LogError("Unable to find behavior " + pair.Key);
        }
    }

    public void SetBehaviorList(Dictionary<System.Type, bool> behaviorList)
    {
        _behaviorList = behaviorList;
    }
}
