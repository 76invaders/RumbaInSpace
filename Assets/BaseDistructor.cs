using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseDistructor : MonoBehaviour
{
    void OnTriggerEnter2D()
    {
        GetComponent<Animator>().Play("BaseDissapear");
    }

    void destroying()
    {
        Destroy(gameObject);
    }
}
