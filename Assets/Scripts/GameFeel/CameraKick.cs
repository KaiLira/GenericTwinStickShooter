using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraKick : MonoBehaviour
{
    [SerializeField]
    private float _distance;

    public void KickCamera()
    {
        Camera.main.transform.Translate(
            Utils.VecFromComponents(
                -_distance,
                transform.rotation.eulerAngles.z
                )
            );
    }
}
