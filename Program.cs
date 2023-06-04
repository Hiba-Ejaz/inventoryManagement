// Create class `Item`, which has barcode, name and quantity, which are private. Each item should have unique barcode, and quantity can not be negative. Provide the following methods:
// 1. Method `IncreaseQuantity` that takes an integer parameter, and increase the amount of item in the inventory.
// 2. Method `DecreaseQuantity` that takes an integer parameter, and decrease the amount of item in the inventory.
// 3. Methods to get name, quantity, barcode.
internal class Program{
    private static void Main(string[] args)
        {
        Item item=new Item(10,"laptop");
        Console.WriteLine($"{item.GetName()} barcode {item.GetBarcode()} has {item.GetQuantity()} quantity before increment");
        item.IncreaseQuantity(4);
        Console.WriteLine($"{item.GetName()} barcode {item.GetBarcode()} has {item.GetQuantity()} quantity after increment");
        item.DecreaseQuantity(2);
        Console.WriteLine($"{item.GetName()} barcode {item.GetBarcode()} has {item.GetQuantity()} quantity after decrement");
        Item item2=new Item(1,"mobile");
        Console.WriteLine($"{item2.GetName()} barcode {item2.GetBarcode()} has {item2.GetQuantity()} quantity before increment");
        item2.IncreaseQuantity(4);
        Console.WriteLine($"{item2.GetName()} barcode {item2.GetBarcode()} has {item2.GetQuantity()} quantity after increment");
        item2.DecreaseQuantity(2);
        Console.WriteLine($"{item2.GetName()} barcode {item2.GetBarcode()} has {item2.GetQuantity()} quantity after decrement");
        Item item3=new Item(1,"tv");
        Console.WriteLine($"{item3.GetName()} barcode {item3.GetBarcode()} has {item3.GetQuantity()} quantity before increment");
        item3.IncreaseQuantity(2);
        Console.WriteLine($"{item3.GetName()} barcode {item3.GetBarcode()} has {item3.GetQuantity()} quantity after increment");
        item3.DecreaseQuantity(4);
        Console.WriteLine($"{item3.GetName()} barcode {item3.GetBarcode()} has {item3.GetQuantity()} quantity after decrement");
        }
        }


class Item{
  public Item(int quantity,string name){
    _barcode=GenerateBarcode();
    _name=name;
      if(_quantity>=0){
        _quantity=quantity;
       }
       else
            {
                throw new ArgumentException("Quantity cannot be negative.");
            }

  }
    private static int _barcode;
    private static int _barcode_assignment=0;
    private string _name;
    private int _quantity;

    private int GenerateBarcode(){
      return  _barcode_assignment+=1; 
    }

    public int GetBarcode(){
        return _barcode;
    }
    public string GetName(){
        return _name;
    }
    public int GetQuantity(){
        return _quantity;
    }
    public void IncreaseQuantity(int quantity){
        _quantity+=quantity;
    }
      public void DecreaseQuantity(int quantity){
        if(_quantity-quantity>=0){
        _quantity-=quantity;
        }
        else{
            throw new Exception("quantity cannot be negative");
        }
    }
    
}


