using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Counters : MonoBehaviour
{
    //--------Обьекты вызова---------
    GameObject _Galaxy;
    Scene _gameOver;
    //-------Переменные класса-------
    int points = 0;
    bool activestate = false;
    public int playerHP = 3;

    //---------Методы движка---------

    void FixedUpdate()
    {
        if (playerHP == 0)
        {
            GameOver();
        }
        BossApear();
    }

    //---------Методы класса---------
    public void PointsCount(int pointsRecived) //Учет очков
    {
        points += pointsRecived;
    }

    public void GalaxyRegistrator() //Назначение обьекта галактики для обращения
    {
        _Galaxy = GameObject.FindGameObjectWithTag("Galaxy");
    }

    void BossApear() //Вызов босса на бой на ножах
    {
        if (points >= 6200 && activestate == false)
        {
            _Galaxy.GetComponent<Animator>().Play("GalaxyShaking");
            activestate = true;
        }
    }

    public void GameOver()
    {
        SceneManager.LoadScene("Game Over");
    }

}
