
using System.Net.Sockets;

public class Customer
{
    private string _name;
    private Address _address;

    // Getters
    public string GetName()
    {
        return _name;
    }
    public Address GetAddress()
    {
        return _address;
    }

    // Constructor
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    //Methods
    public bool LivesInUsa()
    {
        return _address.IsInUSA();
    }
}