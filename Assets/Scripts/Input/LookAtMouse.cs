using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtMouse : MonoBehaviour
{
    private Vector2 _prevMouse = Vector2.zero;

    void Update()
    {
        Vector2 mousePos = Input.mousePosition;

        if (_prevMouse == mousePos)
            return;

        _prevMouse = mousePos;
        transform.rotation = Utils.Rotation(
            Utils.AngleBetween(transform.position,
            Camera.main.ScreenToWorldPoint(mousePos)
            )
        );
    }
}
