using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Ammo : MonoBehaviour
{
    [SerializeField]
    [Min(0)]
    private int _maxAmmo;
    private int _ammo = 0;
    [SerializeField]
    [Min(0)]
    private int _magazineSize;
    private int _inMagazine = 0;
    [SerializeField]
    [Min(0)]
    private float _reloadTime;
    private float _reloadTimer = 0f;
    private bool _reloading = false;
    [SerializeField]
    private UnityEvent _fire;

    [ContextMenu("Fill ammo")]
    private void _fillAmmo()
    {
        _ammo = _maxAmmo;
        _inMagazine = _magazineSize;
    }

    void Start()
    {
        _fillAmmo();        
    }

    public void Fire()
    {
        if (_reloading)
            return;

        if (_inMagazine > 0)
        {
            _inMagazine--;
            _fire.Invoke();
        }
        else
            Reload();
    }

    public void Reload()
    {
        if (_ammo > 0 && !_reloading)
            _reloading = true;
    }

    void Update()
    {
        if (_reloading)
        {
            _reloadTimer += Time.deltaTime;
            if (_reloadTimer >= _reloadTime)
            {
                _reloadTimer = 0f;
                _reloading = false;

                if (_ammo > _magazineSize)
                {
                    _ammo -= _magazineSize;
                    _inMagazine = _magazineSize;
                }
                else
                {
                    _inMagazine = _ammo;
                    _ammo = 0;
                }
            }
        }
    }
}
