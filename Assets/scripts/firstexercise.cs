using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstexercise : MonoBehaviour
{
   
    void Start()
    {
        int count=0;
        while(count<20)
        {
            int num=Random.Range(1,21);
            if(num==5)
            continue;
            else if(num==15)
            break;
            else
            Debug.Log("The number is : "+ num);
            count++;
        }
        
    }
}
