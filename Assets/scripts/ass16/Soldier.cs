using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment18
{

    public class Soldier : Character
    {
        public Soldier(string name, int health, Position pos) : base(name, health, pos)
        {

        }
        public override void DisplayInfo()
        {
            Debug.Log("Soldier");
            base.DisplayInfo();

        }
    }
}
