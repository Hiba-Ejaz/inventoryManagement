namespace src.InventoryManagement;
class Item
{
    public Item(string barcode, string name, int quantity)
    {
        _barcode = barcode;
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
    private static string _barcode;
    private string _name;
    private int _quantity;

    public string GetBarcode()
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

}
