using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    public string playerName;
    public int health;
    public static int playerCount = 0;

    public void InitializePlayer(string name, int initialHealth)
    {
        playerName = name;
        health = initialHealth;
    }
    public void Heal(int amount)
    {
        health += amount;
        Debug.Log("The Health After Increament Is =" + health);
    }
    public void Heal(bool fullRestore)
    {
        if (fullRestore == true)
        {
            health = 100;
            Debug.Log("The Health Is Full");
        }

    }
    public void InitializePlayer()
    {
        playerCount++;
    }
    public void ShowPlayerCount()
    {
        Debug.Log("The Player Object Count Is =" + playerCount);
    }

}
