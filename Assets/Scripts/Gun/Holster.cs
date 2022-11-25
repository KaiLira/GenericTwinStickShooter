using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Holster : MonoBehaviour
{
    [SerializeField]
    private Trigger _currentGun;
    [SerializeField]
    private Trigger _previousGun;

    private void Start()
    {
        _currentGun.Holster = this;
        _currentGun.gameObject.SetActive(true);
    }

    public void TriggerPressed()
    {
        if (_currentGun != null)
            _currentGun.TriggerPressed();
        else
        {
            SwapGuns();
            _currentGun?.TriggerPressed();
        }
    }

    public void TriggerReleased()
    {
        if (_currentGun != null)
            _currentGun.TriggerReleased();
        else {
            SwapGuns();
            _currentGun?.TriggerReleased();
        }
    }

    public void SetGun(Trigger newGun)
    {
        newGun.Holster = this;

        _previousGun = _currentGun;
        _currentGun = newGun;

        _previousGun?.gameObject.SetActive(false);
        _currentGun.gameObject.SetActive(true);
    }

    public void RemoveGun()
    {
        Destroy(_currentGun.gameObject);
        _currentGun = null;
        SwapGuns();
    }

    public void SwapGuns()
    {
        if (_previousGun == null)
            return;

        Trigger tempGun = _previousGun;
        _previousGun = _currentGun;
        _currentGun = tempGun;

        _previousGun?.gameObject.SetActive(false);
        _currentGun.gameObject.SetActive(true);
    }
}
