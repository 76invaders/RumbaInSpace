using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnShawarmas : MonoBehaviour
{
    public GameObject _shawarmaMain;
    void SpawnShawarmasNow()
    {
        Instantiate(_shawarmaMain, transform.position, transform.rotation);
        Instantiate(_shawarmaMain, transform.position, transform.rotation);
    }
}
