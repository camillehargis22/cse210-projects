// Order class
public class Order
{
    // attributes
    private double SHIPPING_USA = 5.00;
    private double SHIPPING_FOREIGN = 35.00;
    private List<Product> _products;
    private Customer _customer;

    // constructor
    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    // methods
    public double GetTotalCost()
    {
        double totalCost = 0.00;

        foreach (Product product in _products)
        {
            totalCost += product.GetTotalPrice();
        }

        totalCost += GetShippingCost();

        return totalCost;
    }

    public string GetPackingLabel()
    {
        string text = "";

        foreach (Product product in _products)
        {
            text += product.GetPackingLabel();
            text += "\n";
        }

        return text;
    }

    public string GetShippingLabel()
    {
        return _customer.GetShippingLabel();
    }

    private double GetShippingCost()
    {
        if (_customer.IsInUSA())
        {
            return SHIPPING_USA;
        }
        else
        {
            return SHIPPING_FOREIGN;
        }
    }
}