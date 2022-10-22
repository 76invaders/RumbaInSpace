using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossLogic : MonoBehaviour
{
    public GameObject _boom, _bigBoom;
    Animator _animator;
    int _bossHealth = 20000;

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
            _animator.Play("ShootAllOneMissleAnimation");
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

}
