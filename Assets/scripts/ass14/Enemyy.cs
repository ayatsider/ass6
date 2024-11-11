using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyy : Character
{
    public Enemyy(string name,int health):base(name,health)
    {
        
    }
    public void Attack(int val)
    {
        playerHealthh -= val;
    }
}
