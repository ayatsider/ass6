using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
namespace Assignment29
{
    public class BasicsScript : MonoBehaviour
    {
        void Start()
        {
            var integerVar = 1;
            var stringVar = "";
            var boolVar = true;
            string result = (integerVar % 2) == 0 ? $"The number {integerVar} is even" : $"The number {integerVar} is odd";
            Debug.Log(result);
            //استخدمت tostring عشان يطبع التاريخ بالتنسيق الي بدي اياه "بس بطبع التاريخ ع التقويم الهجري
            Debug.Log("The current date is :" + DateTime.Now.Date.ToString("yyyy-MM-dd"));
            Debug.Log("The current time is :" + DateTime.Now.TimeOfDay);
            Debug.Log("The current day is :" + DateTime.Now.DayOfWeek);

        }
    }
}
