using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SpaceshipCreator : MonoBehaviour
{
    public GameObject _spaceship;
    Vector3 _position;
    void CreateSpaceship()
    {
        _position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        _position.z = 0;
        Instantiate(_spaceship, _position, Quaternion.identity);
        Destroy(gameObject);
    }

}
