using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider2D))]
public class PushBackOnCollision : MonoBehaviour
{
    [SerializeField, Min(0f)]
    private float _distance;
    [SerializeField]
    private UnityEvent _collided;

    void OnTriggerEnter2D(Collider2D collider)
    {
        var displacement = Utils.VecFromComponents
            (_distance, transform.rotation.eulerAngles.z);
        collider.transform.position += new Vector3(displacement.x, displacement.y, 0);
        _collided?.Invoke();
    }
}
