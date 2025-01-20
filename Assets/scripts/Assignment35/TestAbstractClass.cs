using System.Collections;
using System.Collections.Generic;
using Assignment35;
using UnityEngine;
namespace Assignment35
{
    public class TestAbstractClass : MonoBehaviour
    {
        void Start()
        {
            DerivedClassExample derivedClassExample = new DerivedClassExample();
            derivedClassExample.PerformAction();
            derivedClassExample.PrintInfo();
        }
    }
}
