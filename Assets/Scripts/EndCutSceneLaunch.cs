using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndCutSceneLaunch : MonoBehaviour
{
    public GameObject _cutScene;
    void StartCutScene()
    {
        Instantiate(_cutScene);
    }
}
