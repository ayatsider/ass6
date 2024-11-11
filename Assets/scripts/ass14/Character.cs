using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    public Character(string name, int health)
    {
        playerName = name;
        playerHealth = health;
    }
    public Character():this("",100)
    {
        
    }

    private string playerName = "Subhi";
    public string playerNamee
    {
        get { return playerName; }
        set { playerName = value; }
    }
    private int playerHealth = 20;
    public int playerHealthh
    {
        get { return playerHealth; }
        set
        {
            if (value > 100)
                playerHealth = 100;
            else if (value < 0)
                playerHealth = 0;
            else
                playerHealth = value;
        }
    }

}
