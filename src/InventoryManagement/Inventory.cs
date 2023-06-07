namespace src.InventoryManagement;
using System;
using System.Collections.Generic;
class Inventory{
     private int _maxQuantity;
     private List<Item> items;
     public Inventory(int maxQuantity){
         _maxQuantity=maxQuantity;
          items = new List<Item>();
    }
    public bool AddItem(Item item,int quantity){
        if(items.Count<_maxQuantity){
          if(items.Exists(i=>i.GetBarcode()==item.GetBarcode())){
             Item existingItem=items.Find(i=>i.GetBarcode()==item.GetBarcode());
            existingItem.IncreaseQuantity(quantity);
          }
            else{
            items.Add(item);
            }
           return true;
        }
        else{
            return false;
        }
    }
       public bool RemoveItem(string barcode){
        if(items.Exists(i=>i.GetBarcode()==Int32.Parse(barcode))){
            Item itemToRemove=items.Find(i=>i.GetBarcode()==Int32.Parse(barcode));
            if(itemToRemove!=null)
            items.Remove(itemToRemove);
            return true;
        }
        else{
            return false;
        }
    }     
    public void IncreaseQuantity(int quantity,string barcode)
    {
         if(items.Exists(i=>i.GetBarcode()==Int32.Parse(barcode))){
            Item itemToIncreaseQuantity=items.Find(i=>i.GetBarcode()==Int32.Parse(barcode));
            if(itemToIncreaseQuantity!=null)
            itemToIncreaseQuantity.IncreaseQuantity(quantity);
         }
         else{
             throw new Exception("item not found");
         }
    }
        public void DecreaseQuantity(int quantity,string barcode)
    {
         if(items.Exists(i=>i.GetBarcode()==Int32.Parse(barcode))){
            Item itemToDecreaseQuantity=items.Find(i=>i.GetBarcode()==Int32.Parse(barcode));
            if(itemToDecreaseQuantity!=null)
            itemToDecreaseQuantity.DecreaseQuantity(quantity);
         }
         else{
             throw new Exception("item not found");
         }
    }
    public void ViewInventory()
    {
    foreach (var item in items)
    {
    Console.WriteLine($"name {item.GetName()} barcode {item.GetBarcode()} quantity {item.GetQuantity()}");
    }
    }
    public int GetTotalQuantity { 
    get{
        var count=0;
        foreach (var item in items)
        {
            count+=item.GetQuantity();
        }
        return count;
    } }
    public int GetUniqueItemsQuantity{
        get{
            return items.Count;
        }
    }
    
      ~Inventory()
        {
            Console.WriteLine("Inventory destroyed.");
        }
    }




    
  

