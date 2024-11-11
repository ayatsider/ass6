using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class GameManager2 : MonoBehaviour
{
    void Start()
    {
        Playerr player1 = new Playerr("ayat",20);
        Enemyy ene = new Enemyy("ahmad",50);
        Debug.Log("The player name is :" + player1.playerNamee+" the player health is :"+player1.playerHealthh);
        Debug.Log("The enemy name is :" + ene.playerNamee+" the enemy health is :"+ene.playerHealthh);
        player1.Heal(70);
        Debug.Log("The player health after heal function :" + player1.playerHealthh);
        ene.Attack(10);
        Debug.Log("The enemy health after attack function :" + ene.playerHealthh);
    }
}
