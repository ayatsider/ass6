using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerr : MonoBehaviour
{
    void Start()
    {
        Player player1=new Player();
        player1.InitializePlayer();
        Player player2=new Player();
        player2.InitializePlayer();
        player1.InitializePlayer("Ayat",60);
        player2.InitializePlayer("Alaa",90);
        player1.Heal(10);
        player1.Heal(true);
        player1.ShowPlayerCount();

    }
}
