
public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    // Constructor
    public Address(string street, string city, string state, string country) 
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    // Metods
    public bool IsInUSA()
    {
        if(_country.ToLower() == "usa" || _country.ToLower() == "united state")
        {
            return true;
        } else
        {
            return false;
        }
    }
    public string GetFullAddress()
    {
        return $"\nStreet: {_street}\n"+
               $"City: {_city}\n"+
               $"State: {_state}\n"+
               $"Country: {_country}\n";
    }
}