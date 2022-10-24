using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedUiRotation : MonoBehaviour
{
    RectTransform _RectTransform;
    public Transform _ShipTransform;
    private void Start()
    {
        _RectTransform = GetComponent<RectTransform>();
    }
    void Update()
    {
        _RectTransform.rotation = Quaternion.Euler(0,0,0-_ShipTransform.rotation.z);
    }
}
