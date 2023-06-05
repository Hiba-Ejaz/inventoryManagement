//PrintItem takes 1 parameter of type Item and prints out information
// of a single item with name and barcode
// PrintInventory takes 1 parameter of type Inventory and prints out information of the 
//inventory with the amount of unique items and total number of items.

namespace src.InventoryManagement;

class Printer{
 public void PrintItem(Item item)
        {
            Console.WriteLine($"Name: {item.GetName()}, Barcode: {item.GetBarcode()}");
        }


         public void PrintInventory(Inventory inventory)
        {
            Console.WriteLine("Inventory:");

            Dictionary<string, Item> items = inventory.GetItems();

            foreach (Item item in items.Values)
            {
                Console.WriteLine($"Name: {item.GetName()}, Barcode: {item.GetBarcode()}, Quantity: {item.GetQuantity()}");
            }

            Console.WriteLine($"Total unique items: {items.Count}");
            Console.WriteLine($"Total number of items: {inventory.GetTotalItemCount()}");
        }
}