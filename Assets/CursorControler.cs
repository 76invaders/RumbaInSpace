using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorControler : MonoBehaviour
{
    Vector3 _cursorPoint;
    void FixedUpdate()
    {
        _cursorPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        _cursorPoint.z = 0;
        transform.position = _cursorPoint;
    }
}
