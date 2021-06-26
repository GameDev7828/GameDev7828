using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Saw : MonoBehaviour
{
    [SerializeField] private float _damageAmount = 15f;
    [SerializeField] private UnityEvent _onGetDamaged;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.TryGetComponent(out Health player))
        {
            player.Hp -= _damageAmount;
            _onGetDamaged.Invoke();
        }
    }
}
