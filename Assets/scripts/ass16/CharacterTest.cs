using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment18
{
    public class CharacterTest : MonoBehaviour
    {

        void Start()
        {
            Officer officer1 = new Officer("Ahmad", 50, new Position(1, 2, 3));
            Soldier solider1 = new Soldier();
            Character[] characterArray = { officer1, solider1 };
            for (int i = 0; i < characterArray.Length; i++)
            {
                characterArray[i].DisplayInfo();

            }
            Debug.Log("The solider health befor attack is :" + solider1.characterHealthh);
            officer1.Attack(20, solider1);
            Debug.Log("The solider health after attack is :" + solider1.characterHealthh);

        }
    }

}
