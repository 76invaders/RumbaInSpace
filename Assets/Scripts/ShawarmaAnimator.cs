using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShawarmaAnimator : MonoBehaviour
{
    void OnTriggerEnter2D()
    {
        GetComponent<FirstEncounterEnemy>().ReciveDammage(10);
        GetComponent<Animator>().Play("Shacking");
    }
}
