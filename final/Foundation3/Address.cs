public class Address
{
    // fields to store details
    private string _street;
    private string _city;
    private string _state;
    private string _zipCode;

    // constructor to initialize the fields
    public Address(string street, string city, string state, string zipCode)
    {
        this._street = street; // Assign the street value
        this._city = city;     // Assign the city value
        this._state = state;   // Assign the state value
        this._zipCode = zipCode; // Assign the zip code value
    }

    // Override the ToString method to return the address as a formatted string
    public override string ToString()
    {
        return $"{_street}, {_city}, {_state} {_zipCode}";
    }
}

