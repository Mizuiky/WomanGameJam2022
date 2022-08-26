using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scissor : MonoBehaviour
{
    #region Serializable Fields

    [SerializeField]
    private float _speed;

    [SerializeField]
    private float _rotationSpeed;

    [SerializeField]
    private float _timeToDestroy;

    [SerializeField]
    private float _degrees;

    #endregion

    private float _side = 1;

    public void Start()
    {
        gameObject.SetActive(true);
        Destroy(gameObject, _timeToDestroy);
    }

    public void Update()
    {
        Move();
        Rotate();
    }

    private void Move()
    {
        transform.Translate(Vector2.right * _speed * _side * Time.deltaTime, Space.World);
    }

    private void Rotate()
    {
        transform.Rotate(new Vector3(0, 0, _degrees * _rotationSpeed * Time.deltaTime), Space.Self);
    }

    public void Init(float side)
    {
        _side = side;
    }

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.CompareTag("Enemy"))
    //    {
    //        //dar dano no inimigo
    //        OnDeath();
    //    } 
    //}

    public void OnDeath()
    {
        gameObject.SetActive(false);
        Destroy(gameObject);
    }
}
