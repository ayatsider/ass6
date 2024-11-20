using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Ass18
{
    public class Inventory
    {
        private List<string> itemName = new List<string>();
        public void AddItem(string item)
        {
            itemName.Add(item);
        }
        public void ShowItems()
        {
            foreach (string n in itemName)
            {
                Debug.Log(n);
            }
        }
        public static Inventory operator +(Inventory a, Inventory b)
        {

            Inventory result = new Inventory();
            for (int i = 0; i < a.itemName.Count; i++)
            {
                result.AddItem(a.itemName[i]);
            }
            for (int i = 0; i < b.itemName.Count; i++)
            {
                result.AddItem(b.itemName[i]);
            }

            return result;
        }
    }

}

