using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipDestroyer : MonoBehaviour
{
    public GameObject _explosion;
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.tag == "Shawarma" || hitInfo.tag == "BossMissle")
        {
            GameObject.FindGameObjectWithTag("Counters").GetComponent<Counters>().playerHP -= 1;
            Instantiate(_explosion, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
