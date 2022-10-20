using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int Health = 100;
    public Enemy(int Health)
    {
        this.Health = Health;
    }
}
