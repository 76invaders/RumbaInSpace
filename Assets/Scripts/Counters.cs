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
    int points = 0;
    bool activestate = false;
    public int playerHP = 3;

    //---------������ ������---------

    void FixedUpdate()
    {
        if (playerHP == 0)
        {
            GameOver();
        }
        BossApear();
    }

    //---------������ ������---------
    public void PointsCount(int pointsRecived) //���� �����
    {
        points += pointsRecived;
    }

    public void GalaxyRegistrator() //���������� ������� ��������� ��� ���������
    {
        _Galaxy = GameObject.FindGameObjectWithTag("Galaxy");
    }

    void BossApear() //����� ����� �� ��� �� �����
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
