using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateWithAxes : MonoBehaviour
{
    [SerializeField]
    private string _horizontalAxis = "Aim Horizontal";
    [SerializeField]
    private string _veritcalAxis = "Aim Vertical";

    void Update()
    {
        float horizontal = Input.GetAxis(_horizontalAxis);
        float veritcal = Input.GetAxis(_veritcalAxis);

        if (horizontal == 0f && veritcal == 0f)
            return;

        transform.rotation = Utils.Rotation(
            Utils.AngleBetween(
                Vector2.zero,
                new Vector2(horizontal, -veritcal)
            )
        );
    }
}
