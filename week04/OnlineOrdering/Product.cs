// Product class
public class Product
{
    // attributes
    private string _name;
    private int _productID;
    private double _price;
    private int _quantity;

    // constructor
    public Product(string name, int productID, double price, int quantity)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }

    public double GetTotalPrice()
    {
        return _price * _quantity;
    }

    public string GetPackingLabel()
    {
        return $"Product: {_name}, Product ID: {_productID}";
    }
}