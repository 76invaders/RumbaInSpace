using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossPhases : MonoBehaviour
{
    BossAttacks _bossAttacks;
    private void Start()
    {
        _bossAttacks = GetComponent<BossAttacks>();
    }

    public void LaunchPhase(int Phase)
    {
        switch (Phase)
        {
            //1 Phase 100%hp
            case 1:
                {
                    _bossAttacks.circleRapidShotsFirst();
                    _bossAttacks.circleShotsFirst();
                    _bossAttacks.AutomissilesFireFirst();
                }
                break;
            //2 Phase 75%hp
            case 2:
                {
                    _bossAttacks.circleRapidShotsSecond();
                    _bossAttacks.circleShotsSecond();
                    _bossAttacks.AutomissilesFireSecond();
                }
                break;
            //3 Phase 50%hp
            case 3:
                {
                    _bossAttacks.circleRapidShotsThird();
                    _bossAttacks.circleShotsThird();
                    _bossAttacks.AutomissilesFireThird();
                }
                break;
            //4 Phase 25%hp
            case 4:
                {
                    StopAllCoroutines();
                    _bossAttacks.circleRapidShotsFourth();
                    _bossAttacks.circleShotsFourth();
                    _bossAttacks.AutomissilesFireFourth();
                }
                break;
            //5 Phase 0%hp
            case 5:
                {
                    _bossAttacks.StopFire();
                }
                break;

            default:
                break;
        }
    }
}
