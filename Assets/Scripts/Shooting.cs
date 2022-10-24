using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Shooting : MonoBehaviour
{
    public Transform _firePoint;
    public GameObject _missile;
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    { 
        Instantiate(_missile,_firePoint.position,_firePoint.rotation);
    }
}
