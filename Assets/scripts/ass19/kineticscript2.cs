using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kineticscript2 : MonoBehaviour
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
                cube.Translate(Vector3.down * Time.deltaTime);
            }
        }
        else
        {
            foreach (Transform cube in cubes)
            {
                cube.Translate(Vector3.up * Time.deltaTime);
            }
        }


    }
}
