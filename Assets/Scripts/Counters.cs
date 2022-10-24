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
    int _points = 0;
    bool _activestate = false;
    public int _playerHP = 3;

    //---------Методы движка---------
    void FixedUpdate()
    {
        if (_playerHP <= 0)
        {
            GameOver();
        }
        BossApear();
    }

    //---------Методы класса---------
    public void PointsCount(int pointsRecived) //Учет очков
    {
        _points += pointsRecived;
    }

    public void GalaxyRegistrator() //Назначение обьекта галактики для обращения
    {
        _Galaxy = GameObject.FindGameObjectWithTag("Galaxy");
    }

    void BossApear() //Вызов босса на бой на ножах
    {
        if (_points >= 6200 && _activestate == false)
        {
            _Galaxy.GetComponent<Animator>().Play("GalaxyShaking");
            _activestate = true;
        }
    }

    public void GameOver()
    {
        SceneManager.LoadScene("Game Over");
    }

}
