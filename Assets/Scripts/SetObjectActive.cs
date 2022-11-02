using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetObjectActive : MonoBehaviour
{
    [SerializeField]
    private GameObject m_target;

    public void ActivateTarget()
    {
        m_target.SetActive(true);
    }

    public void DeactivateTarget()
    {
        m_target.SetActive(false);
    }
}
