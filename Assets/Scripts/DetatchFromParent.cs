using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetatchFromParent : MonoBehaviour
{
    public void Detatch()
    {
        transform.parent = null;
    }
}
