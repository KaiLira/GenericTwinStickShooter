using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraKick : MonoBehaviour
{
    [SerializeField]
    private float _distance;

    public void KickCamera()
    {
        float angle = transform.rotation.eulerAngles.z * Mathf.Deg2Rad;

        Vector2 displacement = new(
            -_distance * Mathf.Cos(angle),
            -_distance * Mathf.Sin(angle)
            );

        Camera.main.transform.Translate(displacement);
    }
}
