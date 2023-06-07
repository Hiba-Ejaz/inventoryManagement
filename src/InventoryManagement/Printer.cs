//PrintItem takes 1 parameter of type Item and prints out information
// of a single item with name and barcode
// PrintInventory takes 1 parameter of type Inventory and prints out information of the 
//inventory with the amount of unique items and total number of items.

namespace src.InventoryManagement;

class Printer{
 public void PrintItem(Item item)
 {
    Console.WriteLine($"the item has name {item.GetName()} and its barcode is{item.GetBarcode()}");
 }
 public void PrintInventory(Inventory inventory)
 {
 Console.WriteLine($"total items in the inventory {inventory.GetTotalQuantity}");
 Console.WriteLine($"unique items in the inventory {inventory.GetUniqueItemsQuantity}");
 }
}