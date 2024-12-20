using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment27
{
    public class ass27script : MonoBehaviour
    {
        void Start()
        {
            int a, b;
            a = 1;
            b = 2;
            int c;
            FunCallByValue(a);
            Debug.Log("The variable value after calling the method by value: " + a);
            FunCallByReference(ref b);
            Debug.Log("The variable value after calling the method by reference: " + b);
            OutFun(out c);
            Debug.Log("The variable value after calling the method using the out keyword: " + c);
        }
        public void FunCallByValue(int num)
        {
            num += 10;
        }
        public void FunCallByReference(ref int num)
        {
            num += 10;
        }
        public void OutFun(out int num)
        {
            num = 5;
        }
    }
}
