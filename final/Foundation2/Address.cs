public class Address
{
    private string _street;
    private string _city;
    private string _region;
    private string _country;

    public Address(string street, string city, string region, string country)
    {
        _street = street;
        _city = city;
        _region = region;
        _country = country;
    }

    public string GetStreet() => _street;
    public string GetCity() => _city;
    public string GetRegion() => _region;
    public string GetCountry() => _country;

    public bool LocatedInUSA()
    {
        return _country.Equals("USA", StringComparison.OrdinalIgnoreCase);
    }

    public override string ToString()
    {
        return $"{_street}, {_city}, {_region}, {_country}";
    }
}
