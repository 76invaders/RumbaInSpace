using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissleLogic : MonoBehaviour
{
    Rigidbody2D _rigidbody2D;
    public float speed = 0.5f;
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _rigidbody2D.velocity = transform.right * speed;
    }

}
