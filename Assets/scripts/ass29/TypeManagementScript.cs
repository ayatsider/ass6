using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
namespace Assignment29
{
    public class TypeManagementScript : MonoBehaviour
    {

        void Start()
        {
            Animal animal = new Cat();
            animal.MakeSound();
            animal.Move();
            (animal as Cat)?.MakeSound();
            (animal as Cat)?.Move();
            List<ICanFight> canFights = new List<ICanFight> { new Cat(), new Warrior() };
            for (int i = 0; i < canFights.Count; i++)
            {
                canFights[i].Attack();
            }
            for (int i = 0; i < canFights.Count; i++)
            {
                if (canFights[i] is Cat)
                {
                    Debug.Log("The object is a Cat.");
                }
                else
                    Debug.Log("The object is a Warrior.");
            }

        }
    }
}
