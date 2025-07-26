// Address class
public class Address
{
    // attributes
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    // constructor
    public Address(string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }

    // methods
    // returns if address is in USA or not
    public Boolean IsInUSA()
    {
        if (_country == "USA" || _country == "United States of America")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // returns the full address
    public string GetFullAddress()
    {
        return $"{_streetAddress}\n{_city}, {_state}\n{_country}";
    }
}