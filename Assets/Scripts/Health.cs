using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    [SerializeField] private int _maxHealth;
    [SerializeField] private UnityEvent _onChangeHealth;
    [SerializeField] private UnityEvent _onZeroHealth;
    private int _health;

    public int Hp
    {
        get { return _health; }
    }

    public int MaxHp
    {
        get { return _maxHealth; }
    }

    private void Start()
    {
        _health = _maxHealth;
    }

    public void DealDamage(int amount)
    {
        _health -= amount;
        _onChangeHealth?.Invoke();
        if (_health <= 0)
            _onZeroHealth?.Invoke();
    }
}
