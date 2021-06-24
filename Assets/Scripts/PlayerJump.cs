using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerJump : MonoBehaviour
{
   [SerializeField] private Rigidbody2D _rb;

   [SerializeField] private float _jumpForce = 200;

   private bool _isGrounded;

   [SerializeField] private UnityEvent _onJump;

   public void Update()
   {
      if (Input.GetKeyDown(KeyCode.Space))
      {
         _onJump.Invoke();
      }
   }

   public void AddJumpForce()
   {
      if (_isGrounded)
      {
         _rb.AddForce(new Vector2(0, _jumpForce));
      }
     
   }

   private void OnCollisionStay2D(Collision2D other)
   {
      if (other.gameObject.CompareTag("Ground"))
      {
         _isGrounded = true;
      }
   }

   private void OnCollisionExit2D(Collision2D other)
   {
      if (other.gameObject.CompareTag("Ground"))
      {
         _isGrounded = false;
      }
   }
}
