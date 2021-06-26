using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
  public float Hp { get; set; }

  private void Awake()
  {
    Hp = 100f;
  }
}
