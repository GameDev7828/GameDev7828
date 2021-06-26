using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    [SerializeField] private Animator _animator;


    public void MoveAnimation()
    {
        _animator.SetBool("IsRunning", true);
    }

    public void StopMove()
    {
        _animator.SetBool("IsRunning", false);
    }

    public void HurtAnimation()
    {
        _animator.SetTrigger("IsHurt");
    }
}
