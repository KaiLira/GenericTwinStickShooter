using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider2D))]
public class DamageOnCollision : MonoBehaviour
{
    [SerializeField]
    private int _damage;
    [SerializeField]
    private UnityEvent _collided;

    void OnTriggerEnter2D(Collider2D collider)
    {
        collider.gameObject.GetComponent<Health>()?.DealDamage(_damage);
        _collided?.Invoke();
    }
}
