using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Health))]
public class HealthBar : MonoBehaviour
{
    [SerializeField]
    private GameObject _statusBar;
    private Slider _slider;
    
    void Start()
    {
        _slider = _statusBar.GetComponent<Slider>();

        _slider.maxValue = GetComponent<Health>().MaxHp;
        _slider.value = GetComponent<Health>().MaxHp;
        _slider.interactable = false;
        _slider.wholeNumbers = true;
    }

    public void UpdateValue()
    {
        _slider.value = GetComponent<Health>().Hp;
    }
}
