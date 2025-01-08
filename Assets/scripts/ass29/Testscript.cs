using System.Collections;
using System.Collections.Generic;
using Assignment29;
using UnityEngine;

public class Testscript : MonoBehaviour
{
    void Start()
    {
        int[] num = { 1, 2, 3, 4 };
        print($"The sum of numbers is :{Utilities.Add(num)}");

    }
}
