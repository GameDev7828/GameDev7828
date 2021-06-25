using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private float _damageAmount = 10f;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent(out Health playerHealth))
        {
            playerHealth.Hp -= _damageAmount;
        }
    }

    private void Update()
    {
        DestroyObj();
    }

    public void DestroyObj()
    {
        if (transform.position.y < -5)
        {
           Destroy(gameObject);
        }
    }
}
