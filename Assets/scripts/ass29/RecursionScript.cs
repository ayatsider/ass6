using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace Assignment29
{

    public class RecursionScript : MonoBehaviour
    {

        void Start()
        {
            Debug.Log("Fibonacci Recursive of n=10:  " + FibonacciRecursive(10));
            Debug.Log("Fibonacci Iterative of n=10:  " + FibonacciIterative(10));
            Debug.Log("Fibonacci Recursive of n=30:  " + FibonacciRecursive(30));
            Debug.Log("Fibonacci Iterative of n=30:  " + FibonacciIterative(30));

        }
        public int FibonacciRecursive(int n)
        {
            if (n <= 0)
                return 0;
            if (n == 1)
                return 1;
            return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }
        public int FibonacciIterative(int n)
        {
            if (n <= 0)
                return 0;
            if (n == 1)
                return 1;
            int first = 0;
            int sec = 1;
            int sum = 0;

            for (int i = 2; i <= n; i++)
            {
                sum = first + sec;
                first = sec;
                sec = sum;
            }
            return sum;
        }


        void Update()
        {

        }
    }
}
