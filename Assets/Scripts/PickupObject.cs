using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObject : MonoBehaviour
{
    [SerializeField]
    private float range = 1;
    [SerializeField]
    private Holster _holster;

    public void PickupItem()
    {
        foreach (var gO in GameObject.FindGameObjectsWithTag("Pickuppable"))
        {
            if (Vector2.Distance(transform.position, gO.transform.position) <= range)
            {
                gO.transform.parent = transform;
                gO.transform.localPosition = Vector2.right;
                _holster.SetGun(gO.GetComponent<Trigger>());
                return;
            }
        }
    }
}
