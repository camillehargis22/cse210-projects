// Customer class
public class Customer
{
    // attributes
    private string _name;
    private Address _address;

    // constructor
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // methods
    // returns if address is in USA or not
    public Boolean IsInUSA()
    {
        return _address.IsInUSA();
    }

    // returns the shipping label
    public string GetShippingLabel()
    {
        return $"{_name}\n{_address.GetFullAddress()}";
    }
}