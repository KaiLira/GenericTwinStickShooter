using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageTag : MonoBehaviour
{
    [SerializeField]
    private int _damage;

    public int Damage
    {
        get => _damage;
    }
}
