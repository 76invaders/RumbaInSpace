using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BaseCreator : MonoBehaviour
{
    public GameObject spaceBase;
    void CreateBase(GameObject spaceBase)
    {
        spaceBase.SetActive(true);
        Instantiate(spaceBase, new Vector3(16,0,0), new Quaternion(0,0,0,0));
        this.spaceBase.SetActive(false);
    }
}