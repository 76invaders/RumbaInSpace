using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCameraControl : MonoBehaviour
{
    Transform _transform;
    void Start()
    {
        _transform = GetComponent<Transform>();
    }
    void Update()
    {
        _transform.rotation = new Quaternion (0, 0, _transform.rotation.z + 10f, 0) ;
    }
}
