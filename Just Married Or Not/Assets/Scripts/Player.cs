using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float _playerSpeed;

    [SerializeField]
    private Rigidbody2D _rb;

    [SerializeField]
    private Animator _animator;

    private float _horizontal;
    private float _vertical;

    private bool _canFlip = false;
    

    void Update()
    {
        _horizontal = Input.GetAxis("Horizontal");
        _vertical = Input.GetAxis("Vertical");

        Move();
    }

    private void Move()
    {
        if (_horizontal > 0)
            _canFlip = false;
        else if (_horizontal < 0)
            _canFlip = true;

        Flip();

        if(_horizontal != 0)
        {
            _animator.SetBool("isWalking", true);
            _rb.velocity = new Vector2(_horizontal * _playerSpeed, _rb.velocity.y);
        }
        else
        {
            _animator.SetBool("isWalking", false);
        }
    }

    private void Flip()
    {
        if (_canFlip)
            transform.localScale = new Vector2(-1, 1);
        else
        {
            transform.localScale = new Vector2(1, 1);
        }
    }

    private void Shoot()
    {

    }
}
