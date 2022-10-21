using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Counters : MonoBehaviour
{
    //--------Обьекты вызова---------
    GameObject _Galaxy;

    //-------Переменные класса-------
    int points = 0;
    int health = 3;
    bool activestate = false;

    //---------Методы движка---------
    private void Start()
    {

    }
    void FixedUpdate()
    {
        BossApear();
    }

    //---------Методы класса---------
    public void PointsCount(int pointsRecived) //Учет очков
    {
        points += pointsRecived;
        Debug.Log(points);
    }
    public void GalaxyRegistrator() //Назначение обьекта галактики для обращения
    {
        _Galaxy = GameObject.FindGameObjectWithTag("Galaxy");
    }

    void BossApear()
    {
        if (points >= 6200 && activestate == false)
        {
            _Galaxy.GetComponent<Animator>().Play("GalaxyShaking");
            activestate = true;
            Debug.Log(activestate);
        }
    }
}
