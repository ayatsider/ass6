using System.Collections;
using System.Collections.Generic;
using Ass18;
using Assignment18;
using UnityEngine;
namespace Ass18
{
    public class GameInventory : MonoBehaviour
    {
        void Start()
        {
            Inventory potions = new Inventory();
            potions.AddItem("Healing Potion");
            potions.AddItem("Strength Potion");
            Inventory elixirs = new Inventory();
            elixirs.AddItem("Elixir");
            elixirs.AddItem("Dark Elixir");
            Inventory finalres = potions + elixirs;
            finalres.ShowItems();
        }
    }
}
