using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment29
{
    public class separate : MonoBehaviour
    {
        void Start()
        {
            CustomObject customObject = new CustomObject(100, "Ayat");
            //print("The id is :" + customObject.Id + " and the name is : " + customObject.Name);
            print(customObject.ToString());
        }
    }
}
