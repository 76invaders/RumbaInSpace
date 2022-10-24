using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseVisible : MonoBehaviour
{
    //Prevent animation from chaotic jumping on a start
    void makeVisible()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, 0);
    }
}
