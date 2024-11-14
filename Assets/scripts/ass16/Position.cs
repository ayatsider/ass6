using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment18
{
    public struct Position
    {
        public float x, y, z;
        public Position(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public void printPosition()
        {
            Debug.Log("The value of position X is :" + x);
            Debug.Log("The value of position Y is :" + y);
            Debug.Log("The value of position Z is :" + z);
        }
    }
}
