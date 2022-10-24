using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroyer : MonoBehaviour
{
    void DestroyObject()
    {
        if(gameObject != null)
        {
            Destroy(gameObject);
        }

    }
}