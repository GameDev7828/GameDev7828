using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface IDamagable
{
   float Health { get; set; }
   void Damage(float damageAmount);
}
