using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class FirstEncounterEnemy : MonoBehaviour
{
    Enemy _enemy; //убрать
    private void Start()
    {
        gameObject.AddComponent<Enemy>();
        _enemy = gameObject.GetComponent<Enemy>();
        _enemy.Health = 100;
    }
    public void ReciveDammage(int damage)
    {
        _enemy.Health -= damage;
    }

    private void FixedUpdate()
    {
        if (_enemy.Health <= 0)
        {
            Debug.Log("Убил");
            gameObject.GetComponent<Animator>().Play("ShawarmaDestroingAnimation");
        }
    }
}
