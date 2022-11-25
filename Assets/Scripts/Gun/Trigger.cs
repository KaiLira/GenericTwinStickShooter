using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger: MonoBehaviour
{
    [HideInInspector]
    public Holster Holster;
    public virtual void TriggerPressed() { }
    public virtual void TriggerReleased() { }
}
