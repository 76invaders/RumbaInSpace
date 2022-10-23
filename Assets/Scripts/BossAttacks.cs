using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class BossAttacks : MonoBehaviour
{
    public GameObject _missle, _automissle;
    public GameObject[] _guns = new GameObject[6];

    public void StopFire()
    {
        StopAllCoroutines();
    }

    void ShootAutomissileOne(int PlusAngle = 0)
    {
        GetComponent<AudioSource>().Play();
        _guns[2].GetComponent<BossGunFireActions>().MissileFire(_automissle, PlusAngle);
    }

    void ShootAutomissileTwo(int PlusAngle = 0)
    {
        GetComponent<AudioSource>().Play();
        _guns[1].GetComponent<BossGunFireActions>().MissileFire(_automissle, PlusAngle);
        _guns[3].GetComponent<BossGunFireActions>().MissileFire(_automissle, PlusAngle);
    }

    void ShootAutomissileThree(int PlusAngle = 0)
    {
        GetComponent<AudioSource>().Play();
        _guns[0].GetComponent<BossGunFireActions>().MissileFire(_automissle, PlusAngle);
        _guns[2].GetComponent<BossGunFireActions>().MissileFire(_automissle, PlusAngle);
        _guns[4].GetComponent<BossGunFireActions>().MissileFire(_automissle, PlusAngle);
    }

    void ShootFromCenter(int PlusAngle = 0)
    {
            _guns[5].GetComponent<BossGunFireActions>().MissileFire(_missle, PlusAngle);
    }

    public void AutomissilesFireFirst()
    {
        StartCoroutine(ShootAutomissileOneCorutine(10));
    }

    public void AutomissilesFireSecond()
    {
        StartCoroutine(ShootAutomissileTwoCorutine(15));
    }

    public void AutomissilesFireThird()
    {
        StartCoroutine(ShootAutomissileThreeCorutine(15));
    }

    public void AutomissilesFireFourth()
    {
        StartCoroutine(ShootAutomissileThreeCorutine(10));
    }

    private IEnumerator ShootAutomissileOneCorutine(int Dellay)
    {
        bool loop = true;
        while (loop == true)
        {
            yield return new WaitForSeconds(Dellay);
            ShootAutomissileOne(0);
        }
    }

    private IEnumerator ShootAutomissileTwoCorutine(int Dellay)
    {
        bool loop = true;
        while (loop == true)
        {
            yield return new WaitForSeconds(Dellay);
            ShootAutomissileTwo(0);
        }
    }

    private IEnumerator ShootAutomissileThreeCorutine(int Dellay)
    {
        bool loop = true;
        while (loop == true)
        {
            yield return new WaitForSeconds(Dellay);
            ShootAutomissileThree(0);
        }
    }

    public void circleShotsFirst()
    {
        StartCoroutine(circleShotsCorutine(1, 45));
    }

    public void circleShotsSecond()
    {
        StartCoroutine(circleShotsCorutine(2, 45));
    }

    public void circleShotsThird()
    {
        StartCoroutine(circleShotsCorutine(3, 30));
    }

    public void circleShotsFourth()
    {
        StartCoroutine(circleShotsCorutine(4, 20));
    }

    private IEnumerator circleShotsCorutine(int repeats,int steps)
    {
        while (true)
        {
            for (int rep = 0; rep < repeats; rep++)
            {
                for (int circleCounter = 0; circleCounter <= 360; circleCounter += steps)
                {
                    ShootFromCenter(circleCounter + ((steps/2)*rep)); // :)
                }
                yield return new WaitForSeconds(1f);
            }
            yield return new WaitForSeconds(2f);
        }
    }

    public void circleRapidShotsFirst()
    {
        StopAllCoroutines();
        StartCoroutine(circleRapidFire(60, 360));
    }
    public void circleRapidShotsSecond()
    {
        StopAllCoroutines();
        StartCoroutine(circleRapidFire(60, 180));
    }
    public void circleRapidShotsThird()
    {
        StopAllCoroutines();
        StartCoroutine(circleRapidFire(60, 120));
    }
    public void circleRapidShotsFourth()
    {
        StopAllCoroutines();
        StartCoroutine(circleRapidFire(60, 90));
    }

    private IEnumerator circleRapidFire(int repeats, int steps)
    {
        int circleCounter = 0;
        for (int rep = 0; rep < repeats; rep++)
        {
                for (int bufer = circleCounter; bufer <= 360; bufer += steps)
                {
                    ShootFromCenter(bufer);
                }
            circleCounter -= (360/repeats);
            yield return new WaitForSeconds(0.7f);
        }
    }
}
