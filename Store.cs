using System;
using System.Collections.Generic;

namespace Chapter12
{
    public class Store
    {
        public Store(string name, List<string> initialInventory)
        {
            Name = name;
            Inventory = initialInventory;
        }

        public string Name {get; set;}
        public List<string> Inventory {get; set;}

        public void Welcome()
        {
            int inventoryNum = this.Inventory.Count;
            Console.WriteLine($"Welcome to {this.Name} we have {inventoryNum} items in our store");
        }
    }
}