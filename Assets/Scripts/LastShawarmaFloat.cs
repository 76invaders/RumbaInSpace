using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastShawarmaFloat : MonoBehaviour
{
    Rigidbody2D _rigidbody2D;
    float _randomX;
    float _randomY;

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _randomX = Random.Range(-1.0f, 1.0f);
        _randomY = Random.Range(-1.0f, 1.0f);
    }

    private void FixedUpdate()
    {
        _rigidbody2D.AddForce(new Vector2(_randomX, _randomY));
    }
}
