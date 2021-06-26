using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class DOTweenMove : MonoBehaviour
{
    [SerializeField] private Vector2 _finalPosition;

    private Vector2 _startPosition;

    private Vector2 _currentPosition;

    [SerializeField] private float _duration = 2f;

    private void Start()
    {
        _startPosition = transform.position;
        _currentPosition = _finalPosition;
        MoveGO(_currentPosition);
    }

    private void MoveGO(Vector2 pos)
    {
        transform.DOMove(pos, _duration).OnComplete(() => MoveGO(_currentPosition));
        _currentPosition = _currentPosition == _finalPosition ? _startPosition : _finalPosition;
    }
}
