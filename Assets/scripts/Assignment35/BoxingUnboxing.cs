using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment35
{
    public class BoxingUnboxing : MonoBehaviour
    {
        int health = 100;

        void Start()
        {
            object box = health;
            int unbox = (int)box;
            unbox++;
            Debug.Log("The original int value is " + health);
            Debug.Log("The boxed value is " + box);
            Debug.Log("The unboxed and modified value is " + unbox);
        }
    }
}