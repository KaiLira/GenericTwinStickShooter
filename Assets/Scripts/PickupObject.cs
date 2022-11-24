using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObject : MonoBehaviour
{
    [SerializeField]
    private float range = 1;

    public void PickupItem()
    {
        foreach (var gO in GameObject.FindGameObjectsWithTag("Pickuppable"))
        {
            if (Vector2.Distance(transform.position, gO.transform.position) <= range)
            {
                gO.transform.parent = transform;
                gO.transform.localPosition = Vector2.right;
                
                // if (gO.GetComponent<Rigidbody>() != null)
                //     gO.GetComponent<Rigidbody2D>().drag = 0;

                return;
            }
        }
    }
}
