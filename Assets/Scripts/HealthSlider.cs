using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class HealthSlider : MonoBehaviour
{
    [SerializeField] private Slider _slider;

    [SerializeField] private Health _health;
    
    [SerializeField] private UnityEvent _playerDead;

    private void Start()
    {
        UpdateSliderValue();
    }

    public void UpdateSliderValue()
    {
        if (_health.Hp > 10)
        {
            _slider.value = _health.Hp;
        }
        else
        {
            _playerDead.Invoke();
        }
        
    }
}
