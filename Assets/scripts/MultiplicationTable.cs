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
        // multiplication tables for numbers 1 to 5
        // for(int i=1;i<=5;i++)
        // {
        //     for(int j=1;j<=10;j++)
        //     {
        //         Debug.Log(i+"*"+j+"="+i*j);
        //     }
        // }
        
        for(int i=1;i<=10;i++)
        {
            //Debug.Log(5+"*"+i+"="+i*5);
            Debug.Log(5+"*"+i+"="+Multiply(5,i));
        }
        //Debug.Log("the result is = "+Multiply(2,10));
        
        
    }
}
