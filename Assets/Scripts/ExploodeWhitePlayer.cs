using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExploodeWhitePlayer : MonoBehaviour
{
    public GameObject _explosion;
    void DestroyObject()
    {
        Instantiate(_explosion);
    }

}
