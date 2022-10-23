using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossGunFireActions : MonoBehaviour
{
    public void MissileFire(GameObject MissilePrefab, float PlusRotation)
    {
            Instantiate(MissilePrefab, transform.position, Quaternion.Euler(new Vector3(0,0, transform.eulerAngles.z + PlusRotation)));
    }
}
