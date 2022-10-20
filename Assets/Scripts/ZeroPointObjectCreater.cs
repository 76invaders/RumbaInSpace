using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeroPointObjectCreater : MonoBehaviour
{
    public GameObject Galaxy, Shawarma, Cursor;
    void CreateObjectZeroPoint()
    {
        Instantiate(Galaxy);
        Instantiate(Shawarma);
        Instantiate(Cursor);
    }
}
