using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class ShawarmaMainLogic : MonoBehaviour
{
    public float _scale = 1;
    public float _speed = 10;
    public int _nextHealth = 200;
    GameObject _nextShawarma;

    public int _health;
    private void Start()
    {
        _health = _nextHealth;
        transform.localScale = new Vector3(_scale, _scale, _scale);
        NextParams(ref _scale,ref _speed,ref _nextHealth);
    }

    private void FixedUpdate()
    {
        if (_health <= 0)
        {
            _health = _nextHealth;
            _nextShawarma = gameObject;
            Instantiate(_nextShawarma, transform.position, transform.rotation);
            Instantiate(_nextShawarma, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D()
    {
        ReciveDammage(10);
        Debug.Log($"Попал хехе {_health} осталось");
    }

    void NextParams(ref float scale, ref float speed,ref int health)
    {
        scale = scale * 0.8f;
        speed = speed * 1.5f;
        health = health / 2;
    }

    public void ReciveDammage(int damage)
    {
        _health -= damage;
    }
}
