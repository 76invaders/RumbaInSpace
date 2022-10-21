using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Counters : MonoBehaviour
{
    //--------������� ������---------
    GameObject _Galaxy;

    //-------���������� ������-------
    int points = 0;
    int health = 3;
    bool activestate = false;

    //---------������ ������---------
    private void Start()
    {

    }
    void FixedUpdate()
    {
        BossApear();
    }

    //---------������ ������---------
    public void PointsCount(int pointsRecived) //���� �����
    {
        points += pointsRecived;
        Debug.Log(points);
    }
    public void GalaxyRegistrator() //���������� ������� ��������� ��� ���������
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
