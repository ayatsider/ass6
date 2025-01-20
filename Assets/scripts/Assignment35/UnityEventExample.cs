using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
namespace Assignment35
{
public class UnityEventExample : MonoBehaviour
{
    public UnityEvent onEventTriggered;
    void Start()
    {
        onEventTriggered = new UnityEvent();
        //onEventTriggered.AddListener();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
}
