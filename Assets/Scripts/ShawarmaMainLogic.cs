using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class ShawarmaMainLogic : MonoBehaviour
{
    public float _scale = 1;
    public float _speed = 0.6f;
    public int _nextHealth = 200;
    GameObject _nextShawarma;
    Rigidbody2D _rigidbody2D;

    public int _health;

    float _randomX;
    float _randomY;
    private void Start()
    {
        _health = _nextHealth;
        transform.localScale = new Vector3(_scale, _scale, _scale);
        NextParams(ref _scale,ref _speed,ref _nextHealth);
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _randomX = Random.Range(-1.0f, 1.0f);
        _randomY = Random.Range(-1.0f, 1.0f);
    }

    private void Update()
    {
        if (transform.position.x < -30)
        {
            transform.position = new Vector3(30f, transform.position.y, 0);
        }
        else if (transform.position.x > 30)
        {
            transform.position = new Vector3(-30f, transform.position.y, 0);
        }

        if (transform.position.y < -16)
        {
            transform.position = new Vector3(transform.position.x, 16f, 0);
        }
        else if (transform.position.y > 16)
        {
            transform.position = new Vector3(transform.position.x, -16f, 0);
        }
    }
    private void FixedUpdate()
    {
        if (_nextHealth < 3)
        {
            Destroy(gameObject);
        }

        if (_health <= 0)
        {
            _health = _nextHealth;
            _nextShawarma = gameObject;
            Instantiate(_nextShawarma, transform.position, transform.rotation);
            Instantiate(_nextShawarma, transform.position, transform.rotation);
            Destroy(gameObject);
        }

        _rigidbody2D.AddForce(new Vector2(_randomX, _randomX));
    }

    void OnTriggerEnter2D()
    {
        ReciveDammage(10);
        Debug.Log($"Попал хехе {_health} осталось");
    }

    void NextParams(ref float scale, ref float speed,ref int health)
    {
        scale = scale * 0.8f;
        speed = speed * 1.1f;
        health = health / 2;
    }

    public void ReciveDammage(int damage)
    {
        _health -= damage;
    }
}
