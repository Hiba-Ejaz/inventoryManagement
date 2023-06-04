// Create class `Item`, which has barcode, name and quantity, which are private. Each item should have unique barcode, and quantity can not be negative.
internal class Program{
    private static void Main(string[] args)
        {
    Item item=new Item();
        }
}

class Item{
    private int _barcode;
    private string _name;
    private int _quantity;

    public int Quantity{
       set{ if(_quantity>=0){
        _quantity=_quantity;
       }
       }
       get{
        return _quantity;
       }
        
    }
}


