using System;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
  [SerializeField] private PlayerMove _playerMove;


  public void RotatePlayer()
  {
    if (_playerMove.HorizontalMove < 0)
    {
      LocalScaleSetter(new Vector2(-0.3f, 0.3f));
    }

    else if (_playerMove.HorizontalMove > 0)
    {
      LocalScaleSetter(new Vector2(0.3f, 0.3f));
    }
  }

  public void LocalScaleSetter(Vector2 localScale)
  {
    transform.localScale = localScale;
  }

  private void Update()
  {
    RotatePlayer();
  }
}
