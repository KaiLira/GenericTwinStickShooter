using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PushBackOnCollision : MonoBehaviour
{
    [SerializeField]
    private Transform _target;

    public void CollisionListener(GameObject collider)
    {
        if (!collider.TryGetComponent<PushBackTag>(out var tag))
            return;

        Vector2 displacement = Utils.VecFromComponents(
            tag.Distance,
            collider.transform.rotation.eulerAngles.z
            );
        _target.position += new Vector3(displacement.x, displacement.y, 0);
    }
}
