using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scissor : MonoBehaviour
{
    [SerializeField]
    private float _speed;

    [SerializeField]
    private GameObject _scissor;

    private Vector2 direction = new Vector2(1, 0);

    private int _side = 1;

    private float _timeToDestroy;


    public void Start()
    {
        gameObject.SetActive(true);
        Destroy(gameObject, _timeToDestroy);
    }

    public void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.Translate(direction * _speed * Time.deltaTime * _side);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            //dar dano no inimigo
            Destroy(gameObject);
        }
           
    }

    public void OnDeath()
    {
        gameObject.SetActive(false);
    }
}
