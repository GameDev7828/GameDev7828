using UnityEngine;
using UnityEngine.Events;

public class PlayerMove : MonoBehaviour
{
   private float _horizontalMove;
   public float HorizontalMove => _horizontalMove;
   
   [SerializeField] private float _speed = 5f;
   [SerializeField] private UnityEvent _onPlayerMove;
   [SerializeField] private UnityEvent _onPlayerStopped;

   public void MovePlayer()
   {
      _horizontalMove = Input.GetAxis("Horizontal");
      transform.Translate(new Vector2(_horizontalMove * _speed * Time.deltaTime, 0));

      if (_horizontalMove != 0)
      {
         _onPlayerMove.Invoke();
      }
      else
      {
         _onPlayerStopped.Invoke();
      }
   }

   private void Update()
   {
      MovePlayer();
   }
}
