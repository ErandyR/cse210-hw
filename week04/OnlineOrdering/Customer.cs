
public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string GetCustomerName()
    {
        return _name;
    }

    public Address GetCustomerAddress()
    {
        return _address;
    }

    public bool CustomerInUSA()
    {
        return _address.AddressInUSA();
    }
}