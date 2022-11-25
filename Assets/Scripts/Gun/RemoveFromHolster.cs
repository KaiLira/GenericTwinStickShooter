using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveFromHolster : MonoBehaviour
{
    [SerializeField]
    private Trigger _trigger;

    public void Remove()
    {
        _trigger.Holster.RemoveGun();
    }
}
