using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class SpacesipControler : MonoBehaviour
{
    Vector3 _mousePosition;
    float _moveSpeed = 0.3f;
    Rigidbody2D _rigidBody;
    Vector2 _movePoint;
    Vector3 _buffer;

    void Start()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        _mousePosition  = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        _movePoint = Vector2.Lerp(transform.position, _mousePosition, _moveSpeed);
    }

    private void FixedUpdate()
    {
        _rigidBody.MovePosition(_movePoint);
        _buffer = Vector3.Lerp(transform.right, (_mousePosition - transform.position), _moveSpeed);
        _buffer.z = 0;
        transform.right = _buffer;
    }

}
