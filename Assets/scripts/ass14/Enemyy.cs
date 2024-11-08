using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyy : Character
{
    public void Attack(int val)
    {
        playerHealthh -= val;
    }
}
