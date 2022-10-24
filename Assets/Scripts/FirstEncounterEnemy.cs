using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstEncounterEnemy : MonoBehaviour
{
    int _enemyHealth = 100;

    public void ReciveDammage(int damage)
    {
        _enemyHealth -= damage;
    }

    private void FixedUpdate()
    {
        if (_enemyHealth <= 0)
        {
            Debug.Log("Убил");
            gameObject.GetComponent<Animator>().Play("ShawarmaDestroingAnimation");
        }
    }
}
