using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstexercise : MonoBehaviour
{
   
    void Start()
    {
        //exercise number1 Number Generator
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

        // exercise number2 Funny Sentence Generator

        string[] words={"Cat","Dog","Car","Pizze","Hat","Fish","Tree","Monkey","Ball","Bird"};
        int counter=0;
        string res=" ";
        while(counter<7)
        {
            res+=words[Random.Range(0,11)]+" ";
            counter++;
        }
        Debug.Log(res);
        
    }
}
