namespace src.InventoryManagement;

class Item
{
    public Item(int quantity, string name)
    {
        _barcode = GenerateBarcode();
        _name = name;
        if (_quantity >= 0)
        {
            _quantity = quantity;
        }
        else
        {
            throw new ArgumentException("Quantity cannot be negative.");
        }
    }
    private int _barcode;
    private static int _barcode_assignment = 0;
    private string _name;
    private int _quantity;
    private int GenerateBarcode()
    {
        return _barcode_assignment += 1;
    }
    public int GetBarcode()
    {
        return _barcode;
    }
    public string GetName()
    {
        return _name;
    }
    public int GetQuantity()
    {
        return _quantity;
    }
    public void IncreaseQuantity(int quantity)
    {
        _quantity += quantity;
    }
    public void DecreaseQuantity(int quantity)
    {
        if (_quantity - quantity >= 0)
        {
            _quantity -= quantity;
        }
        else
        {
            throw new Exception("quantity cannot be negative");
        }
    }

    public override int GetHashCode()
    {
        return _barcode.GetHashCode();
    }
}