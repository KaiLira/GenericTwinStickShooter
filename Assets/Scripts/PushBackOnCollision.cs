using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PushBackOnCollision : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D _body;

    public void CollisionListener(GameObject collider)
    {
        if (!collider.TryGetComponent<PushBackTag>(out var tag))
            return;

        Vector2 force = Utils.VecFromComponents(
            tag.Distance,
            collider.transform.rotation.eulerAngles.z
            );

        _body.AddForce(force, ForceMode2D.Impulse);
    }
}
