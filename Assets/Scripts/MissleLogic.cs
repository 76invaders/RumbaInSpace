using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissleLogic : MonoBehaviour
{
    public GameObject _explosion;
    public float speed = 0.5f;
    Rigidbody2D _rigidbody2D;
    
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _rigidbody2D.velocity = transform.right * speed;
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.tag == "Shawarma")
        {
            Instantiate(_explosion,transform.position,transform.rotation);
            Destroy(gameObject);
        }
    }
}
