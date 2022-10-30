using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider2D))]
public class CollisionToEvents : MonoBehaviour
{
    [SerializeField]
    private UnityEvent<GameObject> _solidCollision;
    [SerializeField]
    private UnityEvent<GameObject> _triggerCollision;

    void OnCollisionEnter2D(Collision2D collision)
    {
        _solidCollision?.Invoke(collision.gameObject);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        _triggerCollision?.Invoke(collision.gameObject);
    }
}
