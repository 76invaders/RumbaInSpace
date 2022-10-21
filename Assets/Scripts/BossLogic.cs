using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossLogic : MonoBehaviour
{
    Animator _animator;
    public GameObject _missle, _automissle, _attentionmarker, _boom, _bigBoom;
    public GameObject[] guns = new GameObject[5];

    Vector3 _defaultPosition = new Vector3(0, 8, 0);
    int _bossHealth = 5000;
    int _randomvalue;

    void Start()
    {
        _animator = GetComponent<Animator>();
        _animator.Play("BossAppear");
    }
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.tag == "Missle")
        {
            _bossHealth -= 100;
            Debug.Log(_bossHealth);
        }
        else if (hitInfo.tag == "Player")
        {
            _bossHealth -= 200;
            Debug.Log(_bossHealth);
        }
    }

    void ExplosionSpawner()
    { 
        Vector3 Spawnposition = new Vector3(transform.position.x + UnityEngine.Random.Range(-12.0f,12.0f), transform.position.y + UnityEngine.Random.Range(-12.0f, 7.0f), 0);
        Instantiate(_boom, Spawnposition, new Quaternion(0, 0, 0, 0));
    }

    void FinalBlow()
    {
        Instantiate(_bigBoom, new Vector3(transform.position.x, transform.position.y, 0), new Quaternion(0, 0, 0, 0));
    }

    void ColliderActivator()
    {
        gameObject.GetComponent<BoxCollider2D>().enabled = true;
    }

    void ColliderDeactivator()
    {
        gameObject.GetComponent<BoxCollider2D>().enabled = false;
    }
}
