using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerr : Character
{
    public Playerr(String name,int health):base(name,health)
    {
        
    }
    public void Heal(int val)
    {
        playerHealthh += val;
    }
}
