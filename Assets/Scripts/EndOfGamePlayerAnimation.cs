using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndOfGamePlayerAnimation : MonoBehaviour
{
public GameObject _shawarma;
    public void Magic()
    {
        Instantiate(_shawarma, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}

