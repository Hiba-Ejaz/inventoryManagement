// Create class `Item`, which has barcode, name and quantity, which are private. Each item should have unique barcode, and quantity can not be negative. Provide the following methods:
// 1. Method `IncreaseQuantity` that takes an integer parameter, and increase the amount of item in the inventory.
// 2. Method `DecreaseQuantity` that takes an integer parameter, and decrease the amount of item in the inventory.
// 3. Methods to get name, quantity, barcode.
using src.InventoryManagement;
internal class Program
{
    private static void Main(string[] args)
    {
        Inventory inventory = new Inventory(200);
        Item item1 = new Item("123", "Laptop", 10);
        Item item2 = new Item("678", "Mobile", 5);
        inventory.ViewInventory();
        Printer printer = new Printer();
        printer.PrintInventory(inventory);
        inventory.IncreaseQuantity(3, "123");
        inventory.DecreaseQuantity(2, "678");
        printer.PrintInventory(inventory);
        inventory.RemoveItem("123");
        printer.PrintInventory(inventory);
        var items = inventory.GetItems();
        int totalItemCount = inventory.GetTotalItemCount();
        Console.WriteLine($"Total Item Count: {totalItemCount}");
        Console.WriteLine("Items:");
        foreach (var item in items.Values)
        {
            printer.PrintItem(item);
        }
    }
}













