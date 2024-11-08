using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class GameManager2 : MonoBehaviour
{
    void Start()
    {
        Playerr player1 = new Playerr();
        Enemyy ene = new Enemyy();
        Debug.Log("The player name is :" + player1.playerNamee);
        Debug.Log("The player health is :" + player1.playerHealthh);
        player1.Heal(70);
        Debug.Log("The player health after heal function :" + player1.playerHealthh);
        ene.Attack(10);
        Debug.Log("The player health after attack function :" + ene.playerHealthh);
    }
}
