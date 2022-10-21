using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAppear : MonoBehaviour
{
    public GameObject _boss;
    void AppearBossNow()
    {
        Instantiate(_boss, new Vector3(0, 8, 0), new Quaternion());
    }

}
