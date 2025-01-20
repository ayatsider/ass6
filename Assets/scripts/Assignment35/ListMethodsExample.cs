using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
namespace Assignment35
{
    public class ListMethodsExample : MonoBehaviour
    {
        List<int> numbers = new List<int>() { 3, 1, 4, 1, 5, 9 };
        List<int> numbers2 = new List<int>() { 3, 1, 4, 1, 5, 9, 2, 6 };
        List<int> filteredNumbers;
        void Start()
        {
            numbers.Sort((x, y) => y.CompareTo(x));
            Debug.Log(string.Join(", ", numbers));
            filteredNumbers = numbers2.FindAll(x => x % 2 == 0);
            Debug.Log(string.Join(", ", filteredNumbers));
        }
    }
}
