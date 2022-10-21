using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroyer : MonoBehaviour
{
    // Start is called before the first frame update
    void DestroyObject()
    {
        if(gameObject != null)
        {
            +=
            Destroy(gameObject);
        }

    }

}