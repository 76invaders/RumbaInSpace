using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class BossAttacks : MonoBehaviour
{
    public GameObject _missle, _automissle;
    public GameObject[] _guns = new GameObject[6];


    private void Start()
    {
        
    }

    public void ShootOneMissileAll(int PlusAngle = 0)
    {
        for (int Count = 0;Count < 5;Count++)
        {
            _guns[Count].GetComponent<BossGunFireActions>().MissleFire(_missle, PlusAngle);
        }
    }
    public void ShootFromCenter(int PlusAngle = 0)
    {
            _guns[5].GetComponent<BossGunFireActions>().MissleFire(_missle, PlusAngle);
    }

    public void reverseDammageOne()
    {
        StartCoroutine(reverseDammageCorutine(1));
    }

    public void reverseDammageTwo()
    {
        StartCoroutine(reverseDammageCorutine(2));
    }

    public void reverseDammageThree()
    {
        StartCoroutine(reverseDammageCorutine(3));
    }

    public void reverseDammageFour()
    {
        StartCoroutine(reverseDammageCorutine(4));
    }

    private IEnumerator reverseDammageCorutine(int Repeats)
    {
        for(int rep = 0; rep < Repeats; rep++)
        {
            ShootOneMissileAll(Random.Range(-90,90));
            yield return new WaitForSeconds(1f);
        }
    }



    public void circleShotsEght()
    {
        StartCoroutine(circleShotsCorutine(1, 45, 0));
    }

    private IEnumerator circleShotsCorutine(int repeats,int steps, int plusDegree)
    {
        while (true)
        {
            for (int rep = 0; rep < repeats; rep++)
            {
                for (int circleCounter = 0; circleCounter <= 360; circleCounter += steps)
                {
                    ShootFromCenter(circleCounter + plusDegree);
                }
            }
            yield return new WaitForSeconds(1f);
        }
    }

    private IEnumerator doNothing(int seconds)
    {
        yield return new WaitForSeconds(seconds);
    }
}
