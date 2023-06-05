namespace src.InventoryManagement;
using System;
using System.Collections.Generic;

// Create class Inventory, which can have only 1 instance, with the following properties and methods:

// items: stores the inventory items and their quantity. Each item can only appear once in the inventory. 
// maxCapacity: stores the maximum total amount of items that can be stored in the inventory.
// A constructor that takes an integer value as the maximum capacity of the inventory and
//  initializes the items. Use access modifiers to protect the items and maxCapacity property 
// from direct external modifications.
// Method AddItem that takes two parameters (item and item quantity) and adds the item to the inventory.
//  If the inventory reaches maxCapacity, the method should return false. 
// Otherwise, it should add or replace the item in items.
// Method RemoveItem that takes a string parameter (item barcode) and removes the item from the inventory. 
//If the item does not exist in the inventory, the method should return false.
// Otherwise, it should remove the item from items and return true.
// Method IncreaseQuantity that takes an integer parameter and a string parameter (item barcode), 
// and increase the amount of item in the inventory.
// Method DecreaseQuantity that takes an integer parameter and a string parameter (item barcode),
//  and decrease the amount of item in the inventory.
// Method called ViewInventory that prints the items (barcode, name, quantity) in the inventory 
// to the console.
// A destructor that prints a message to the console when the inventory is destroyed.

class Inventory{
        private Dictionary<string, Item> _items;
        private int _maxCapacity;
        public Inventory(int maxCapacity)
        {
            _items = new Dictionary<string, Item>();
            _maxCapacity = maxCapacity;
        }

        public bool AddItem(Item item, int quantity)
        {
            if (_items.Count >= _maxCapacity)
            {
                return false;
            }

            if (_items.ContainsKey(item.GetBarcode()))
            {
                throw new ArgumentException("Item with the same barcode already exists in the inventory.");
            }

            _items.Add(item.GetBarcode(), item);
            item.IncreaseQuantity(quantity);
            return true;
        }

        public bool RemoveItem(string barcode)
        {
            if (_items.ContainsKey(barcode))
            {
                _items.Remove(barcode);
                return true;
            }

            return false;
        }

        public void IncreaseQuantity(int amount, string barcode)
        {
            if (_items.ContainsKey(barcode))
            {
                _items[barcode].IncreaseQuantity(amount);
            }
        }

        public void DecreaseQuantity(int amount, string barcode)
        {
            if (_items.ContainsKey(barcode))
            {
                _items[barcode].DecreaseQuantity(amount);
            }
        }

        public void ViewInventory()
        {
            foreach (Item item in _items.Values)
            {
                Console.WriteLine($"Barcode: {item.GetBarcode()}, Name: {item.GetName()}, Quantity: {item.GetQuantity()}");
            }
        }

        ~Inventory()
        {
            Console.WriteLine("Inventory destroyed.");
        }
    }




    
  

