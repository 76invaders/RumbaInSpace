using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCameraControl : MonoBehaviour
{
    Transform tr;
    void Start()
    {
        tr = GetComponent<Transform>();
    }
    void Update()
    {
        tr.rotation = new Quaternion (0, 0, tr.rotation.z + 10f, 0) ;
    }
}
