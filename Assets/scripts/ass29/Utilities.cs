using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment29
{
    public static class Utilities
    {
        public static int Add(params int[] numbers)
        {
            int result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                result += numbers[i];
            }
            return result;


        }
        public static string RepeatString(this string word, int num)
        {
            string res = "";
            for (int i = 0; i < num; i++)
            {
                res += word;
            }
            return res;
        }

    }
}