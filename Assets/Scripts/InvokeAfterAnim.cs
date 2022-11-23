using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InvokeAfterAnim : MonoBehaviour
{
    [SerializeField]
    private Animator m_animator;
    [SerializeField]
    private UnityEvent m_animLooped;

    public void Started()
    {
        StartCoroutine(invokeAfter(
            m_animator.GetCurrentAnimatorStateInfo(0).length
            ));
    }

    private IEnumerator invokeAfter(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        m_animLooped?.Invoke();
    }
}
