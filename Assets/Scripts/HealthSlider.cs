using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSlider : MonoBehaviour
{
    [SerializeField] private Slider _slider;

    [SerializeField] private Health _health;

    private void Start()
    {
        UpdateSliderValue();
    }

    public void UpdateSliderValue()
    {
        _slider.value = _health.Hp;
        print(_health.Hp);
    }
}
