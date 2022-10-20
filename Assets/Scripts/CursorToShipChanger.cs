using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorToShipChanger : MonoBehaviour
{
    public GameObject _spaceship;

    void OnTriggerEnter2D()
    {
        Debug.Log("Поехали!");
        Instantiate(_spaceship,new Vector3(16,0,0),Quaternion.identity);
        Destroy(gameObject);
    }
}
