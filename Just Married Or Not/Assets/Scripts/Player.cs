using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    public float _playerSpeed;

    [SerializeField]
    public Rigidbody2D _rb;

    private float _horizontal;
    private float _vertical;
    
    void Start()
    {
        
    }

    void Update()
    {
        _horizontal = Input.GetAxis("Horizontal");
        _vertical = Input.GetAxis("Vertical");

        Move();
    }

    private void Move()
    {
        if(_horizontal != 0)
        {
            _rb.velocity = new Vector2(_horizontal * _playerSpeed, _rb.velocity.y);
        }
        
    }
}
