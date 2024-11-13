using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment18
{
    public class Character
    {
        public string characterName;
        private int characterHealth;
        public int characterHealthh
        {
            get { return characterHealth; }
            set
            {
                if (value > 100)
                    characterHealth = 100;
                else if (value < 0)
                    characterHealth = 0;
                else
                    characterHealth = value;
            }
        }
        protected Position characterPosition = new Position();
        public Character(string name, int health, Position pos)
        {
            this.characterName = name;
            this.characterHealth = health;
            this.characterPosition = pos;

        }
        public Character() : this("No name", 100, new Position(0, 0, 0))
        {

        }
        public virtual void DisplayInfo()
        {
            Debug.Log("The player name is :" + characterName);
            Debug.Log("The player health is :" + characterHealth);
            characterPosition.printPosition();

        }
        public void Attack(int damage, Character playerchar)
        {
            playerchar.characterHealth -= damage;
        }
        public void Attack(int damage, Character playerchar, string attackType)
        {
            Attack(damage, playerchar);
            Debug.Log("The attack type is :" + attackType);
        }
    }

}
