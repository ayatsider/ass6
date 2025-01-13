using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
namespace Assignment29
{
    public class UnitySpecificScript : MonoBehaviour
    {

        void OnEnable()
        {
            print("GameObject Enabled");
        }
        void Start()
        {
            print("Game started!");
            if (GameObject.Find("TargetObject") != null)
            {
                print("Found object by name: TargetObject");
            }
            else
            {
                print("No TargetObject found.");
            }
            if (GameObject.FindGameObjectsWithTag("Joker") != null)
            {
                print("Found object by tag: Joker");
            }
            else
            {
                print("No Joker object found.");
            }
            if (GameObject.FindAnyObjectByType<Light>() != null)
            {
                print("Found object of type Light: Directional Light");
            }
            else
            {
                print("No Light object found.");
            }

        }
        void OnDisable()
        {
            print("GameObject Disabled");

        }
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                GameObject.Find("TargetObject").SetActive(false);
                print("TargetObject deactivated!");
            }

        }
    }
}
