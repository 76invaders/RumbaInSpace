using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShawarmaAnimator : MonoBehaviour
{
    void OnTriggerEnter2D()
    {
        Debug.Log("Äðûã!");
        GetComponent<Animator>().Play("Shacking");
    }
}
