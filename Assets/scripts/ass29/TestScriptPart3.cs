using System.Collections;
using System.Collections.Generic;
using Assignment29;
using UnityEngine;
namespace Assignment29
{
    public class TestScriptPart3 : MonoBehaviour
    {

        void Start()
        {
            Debug.Log(Utilities.Add(1, 2, 3, 4, 5));
            Debug.Log("Ayat".RepeatString(4));
        }
    }
}
