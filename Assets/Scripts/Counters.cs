using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Counters : MonoBehaviour
{
    //--------������� ������---------
    GameObject _Galaxy;
    Scene _gameOver;

    //-------���������� ������-------
    int _points = 0;
    bool _activestate = false;
    public int _playerHP = 3;

    //---------������ ������---------
    void FixedUpdate()
    {
        if (_playerHP <= 0)
        {
            GameOver();
        }
        BossApear();
    }

    //---------������ ������---------
    public void PointsCount(int pointsRecived) //���� �����
    {
        _points += pointsRecived;
    }

    public void GalaxyRegistrator() //���������� ������� ��������� ��� ���������
    {
        _Galaxy = GameObject.FindGameObjectWithTag("Galaxy");
    }

    void BossApear() //����� ����� �� ��� �� �����
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
