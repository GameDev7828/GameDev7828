using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Ball : MonoBehaviour
{
    [SerializeField] private float _damageAmount = 10f;
    [SerializeField] private float _yPos = -5;
    [SerializeField] private UnityEvent _onPlayerDamaged;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent(out Health playerHealth))
        {
            playerHealth.Hp -= _damageAmount;
            _onPlayerDamaged.Invoke();
        }
    }

    private void Update()
    {
        DestroyObj();
    }

    public void DestroyObj()
    {
        if (transform.position.y < _yPos)
        {
           Destroy(gameObject);
        }
    }
}
