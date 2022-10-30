using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DamageOnCollision : MonoBehaviour
{
    [SerializeField]
    private UnityEvent<int> _onDamage;

    public void ListenToCollision(GameObject _collider)
    {
        if (_collider.TryGetComponent<DamageTag>(out var tag))
            _onDamage?.Invoke(tag.Damage);
    }
}
