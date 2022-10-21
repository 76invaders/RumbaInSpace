using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossLogic : MonoBehaviour
{
    Animator _animator;
    public GameObject _missle, _automissle, _attentionmarker, _boom;
    public GameObject[] guns = new GameObject[5];

    Vector3 _defaultPosition = new Vector3(0, 8, 0);
    int _bossHealth = 5000;
    int _randomvalue;

    void Start()
    {
        _animator = GetComponent<Animator>();
        _animator.Play("BossAppear");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ExplosionSpavner()
    { 
        Vector3 Spawnposition = new Vector3(transform.position.x + Random.Range(-12.0f,12.0f), transform.position.y + Random.Range(-12.0f, 12.0f), 0);
        Instantiate(_boom, Spawnposition, new Quaternion(0, 0, 0, 0));
    }
}
