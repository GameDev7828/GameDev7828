using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollo : MonoBehaviour
{
    [SerializeField] private Transform _playerMove;

    private float _offset;

    private void LateUpdate()
    {
        Vector3 temp = transform.position;

        temp.x = _playerMove.position.x;

        temp.x += _offset;

        transform.position = temp;
    }
}
