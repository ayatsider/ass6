using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class kineticscript : MonoBehaviour
{
    public Transform[] cubes;
    void Start()
    {

    }
    void Update()
    {
        if (Time.time < 4)
        {
            foreach (Transform cube in cubes)
            {
                cube.Translate(Vector3.up * Time.deltaTime);
            }
        }
        else
        {
            foreach (Transform cube in cubes)
            {
                cube.Translate(Vector3.down * Time.deltaTime);
            }
        }


    }
}
