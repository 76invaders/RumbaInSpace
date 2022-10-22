using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossGunFireActions : MonoBehaviour
{
    public void MissleFire(GameObject MisslePrefab,float PlusRotation)
    {
            Instantiate(MisslePrefab, transform.position, Quaternion.Euler(new Vector3(0,0, transform.eulerAngles.z + PlusRotation)));
    }
}
