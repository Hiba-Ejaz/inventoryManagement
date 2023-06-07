
using src.InventoryManagement;
internal class Program
{
    private static void Main(string[] args)
    {
            Inventory inventory = new Inventory(5);
             Printer printer=new Printer();
            Item item1 = new Item(10, "Item 1");
            Item item2 = new Item(5, "Item 2");
            Item item3 = new Item(3, "Item 3");
            inventory.AddItem(item1, 2);
            inventory.AddItem(item2, 1);
            inventory.AddItem(item3, 4);
            Console.WriteLine("Inventory:");
            inventory.ViewInventory();
            inventory.IncreaseQuantity(3, item1.GetBarcode().ToString());
            Console.WriteLine("Updated Inventory:");
            inventory.ViewInventory();
            inventory.DecreaseQuantity(2, item3.GetBarcode().ToString());
            Console.WriteLine("Updated Inventory:");
            inventory.ViewInventory();
            printer.PrintItem(item1);
            printer.PrintInventory(inventory);
            Console.ReadLine();
            bool removed = inventory.RemoveItem(item2.GetBarcode().ToString());
            Console.WriteLine($"Item removed: {removed}");
            removed = inventory.RemoveItem("999");
            Console.WriteLine($"Item removed: {removed}");
            Console.WriteLine("Final Inventory:");
            inventory.ViewInventory();
            printer.PrintItem(item1);
            printer.PrintInventory(inventory);
            Console.ReadLine();
}
}












