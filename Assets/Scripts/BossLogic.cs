using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossLogic : MonoBehaviour
{
    public GameObject _boom, _bigBoom;
    int _bossHealth = 20000;

    BossPhases _phases;
    Animator _animator;

    void Start()
    {
        _animator = GetComponent<Animator>();
        _animator.Play("BossAppear");
        _phases = GetComponent<BossPhases>();
    }

    //Recive dammage logic
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.tag == "Missle" || hitInfo.tag == "Player")
        {
            _bossHealth -= 100;
            switch (_bossHealth)
            {
                case 19900:
                    LaunchPhase(1);
                    break;
                case 15000:
                    LaunchPhase(2);
                    break;
                case 10000:
                    LaunchPhase(3);
                    break;
                case 5000:
                    LaunchPhase(4);
                    break;
                case <=0:
                    LaunchPhase(5);
                    _animator.Play("BossEnd");
                    break;
                default:
                    break;
            }
            //Debug.Log(_bossHealth);
        }
    }

    //Phases launcher
    void LaunchPhase(int phase)
    {
        _phases.LaunchPhase(phase);
        //Debug.Log(phase);
    }

    //End animation scripts
    void ExplosionSpawner()
    { 
        Vector3 spawnposition = new Vector3(transform.position.x + UnityEngine.Random.Range(-12.0f,12.0f), transform.position.y + UnityEngine.Random.Range(-12.0f, 7.0f), 0);
        Instantiate(_boom, spawnposition, new Quaternion(0, 0, 0, 0));
    }

    void FinalBlow()
    {
        Instantiate(_bigBoom, new Vector3(transform.position.x, transform.position.y, 0), new Quaternion(0, 0, 0, 0));
    }

}
