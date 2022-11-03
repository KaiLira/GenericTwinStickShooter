using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider2D))]
public class CollisionEvent : MonoBehaviour
{
    [SerializeField]
    private UnityEvent<GameObject> _onCollision;

    void OnCollisionEnter2D(Collision2D collision)
    {
        _onCollision?.Invoke(collision.gameObject);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        _onCollision?.Invoke(collision.gameObject);
    }
}
