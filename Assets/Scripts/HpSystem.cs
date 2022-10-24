using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HpSystem : MonoBehaviour
{
    public GameObject _health1, _health2, _health3;
    Counters _counter;   
    void Start()
    {
        _counter = GameObject.FindGameObjectWithTag("Counters").GetComponent<Counters>();
    }

    void FixedUpdate()
    {
        HPCheck(_counter._playerHP);
    }

    void HPCheck(int HP)
    {
        switch (HP)
        {
            case 3:
                break;
            case 2:
                _health3.SetActive(false);
                break;
            case 1:
                _health3.SetActive(false);
                _health2.SetActive(false);
                break;
            case <=0:
                _health3.SetActive(false);
                _health2.SetActive(false);
                _health1.SetActive(false);
                break;
            default:
                break;
        }
    }
}
