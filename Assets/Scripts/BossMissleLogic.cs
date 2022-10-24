using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMissileLogic : MonoBehaviour
{
    public float _speed = 0.5f;
    Rigidbody2D _rigidbody2D;

    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _rigidbody2D.velocity = transform.right * _speed;
    }
}
