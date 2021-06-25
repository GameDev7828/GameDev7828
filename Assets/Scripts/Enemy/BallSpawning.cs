using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawning : MonoBehaviour
{
   [SerializeField] private Ball _ball;
   [SerializeField] private int _waitTime;

   private void Start()
   {
      StartCoroutine(SpawnBalls());
   }

   private IEnumerator SpawnBalls()
   {
      while (true)
      {
         Instantiate(_ball, transform.position, Quaternion.identity);
         yield return new WaitForSeconds(_waitTime);
      }
   }
}
