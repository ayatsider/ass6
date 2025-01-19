using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment35
{
    public class MulticastDelegateExample : MonoBehaviour
    {
        public delegate void MathOperation(int number);
        void DoubleNumber(int number)
        {
            int res = number * 2;
            Debug.Log("Double: " + res);
        }
        void SquareNumber(int number)
        {
            int res = number * number;
            Debug.Log("Square: " + res);
        }
        void CubeNumber(int number)
        {
            int res = number * number * number;
            Debug.Log("Cube: " + res);
        }
        MathOperation operation = null;
        void Start()
        {
            operation += DoubleNumber;
            operation += SquareNumber;
            operation += CubeNumber;
            operation?.Invoke(5);// عشان ما يعطيني اكسبشن في حال ما اسندت للديليجت فنكشنات
        }
    }
}