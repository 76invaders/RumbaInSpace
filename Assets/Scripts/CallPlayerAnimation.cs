using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallPlayerAnimation : MonoBehaviour
{
    void MakeAMagic()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<EndOfGamePlayerAnimation>().Magic();
    }
}
