using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossLogic : MonoBehaviour
{
    Animator _animator;
    void Start()
    {
        _animator = GetComponent<Animator>();
        _animator.Play("BossAppear");
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void DefaultPosition()
    {
        GetComponent<Transform>().position = new Vector3(0, 8, 0);
    }
}
