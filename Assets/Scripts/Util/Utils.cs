using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Utils
{
    public static float AngleBetween(Vector2 a, Vector2 b)
    {
        return 270f - Mathf.Atan2(a.x - b.x, a.y - b.y) * Mathf.Rad2Deg;
    }

    public static float Angle(Vector2 vec)
    {
        return 270f - Mathf.Atan(vec.y / vec.x) * Mathf.Rad2Deg;
    }

    public static Quaternion Rotation(float z)
    {
        return Quaternion.Euler(0, 0, z);
    }
}
