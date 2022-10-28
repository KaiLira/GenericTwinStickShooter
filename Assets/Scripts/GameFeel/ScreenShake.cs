using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenShake : MonoBehaviour
{
    [SerializeField, Min(0)]
    private float _intensity = 0;
    [SerializeField, Min(0)]
    private float _duration = 0;
    private bool _shaking = false;
    private float _multiplier;
    private Coroutine _coroutine;

    public void ShakeScreen()
    {
        _multiplier = _intensity * 0.01f;
        _shaking = true;
        if (_coroutine != null)
            StopCoroutine(_coroutine);
        _coroutine = StartCoroutine(_stopShaking());
    }

    private IEnumerator _stopShaking()
    {
        yield return new WaitForSeconds(_duration);
        _shaking = false;
    }

    void Update()
    {
        if (!_shaking)
            return;

        Camera.main.transform.Translate(Vector2.one.normalized * _multiplier);
        _multiplier *= -0.90f;
    }
}
