using System;
using System.Collections;
using System.Collections.Generic;
using Ass18;
using UnityEngine;
namespace Ass18
{
    public class GenericsTest : MonoBehaviour
    {
        void Start()
        {

            GameContainer<string> obj = new GameContainer<string>();
            obj.SetItem("Healing Potion");
            obj.GetItem();
            string res = GameUtils.DescribeItem<string>("Healing Potion");
            Debug.Log(res);

        }
    }

}

