using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment35
{
    public class BuiltInDelegatesExample : MonoBehaviour
    {
        Action logMessage = () => Debug.Log("Hello from Action delegate!");
        Func<int, int> square = (int num) => num * num;
        Predicate<int> isEven = (int num) => (num % 2 == 0 ? true : false);
        void Start()
        {
            logMessage?.Invoke();
            Debug.Log($"Square: {square?.Invoke(5)}");
            Debug.Log($"Is 4 even? {isEven?.Invoke(4)}");
        }
    }
}
