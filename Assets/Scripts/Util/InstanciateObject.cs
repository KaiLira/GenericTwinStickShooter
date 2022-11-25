using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciateObject : MonoBehaviour
{
    [SerializeField]
    private GameObject _prefab;

    public void Instanciate()
    {
        var instance = Instantiate(_prefab);
        instance.transform.SetPositionAndRotation
            (transform.position, transform.rotation);
    }
}
