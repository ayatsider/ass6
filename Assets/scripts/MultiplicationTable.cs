using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplicationTable : MonoBehaviour
{

    int Multiply (int num1,int num2)
    {
        int res=num1*num2;
        return res;
    }
    void Start()
    {
        for(int i=1;i<=5;i++)
        {
            for(int j=1;j<=10;j++)
            {
                Debug.Log(i+"*"+j+"="+i*j);
            }
        }
        
    }
}
