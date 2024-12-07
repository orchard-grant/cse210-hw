public class Address
{
    private string street;
    private string city;
    private string region;
    private string country;

    public Address(string street, string city, string region, string country)
    {
        this.street = street;
        this.city = city;
        this.region = region;
        this.country = country;
    }

    public string Street => street;
    public string City => city;
    public string Region => region;
    public string Country => country;

    public bool LocatedInUSA()
    {
        return country.Equals("USA", StringComparison.OrdinalIgnoreCase);
    }

    public override string ToString()
    {
        return $"{street}, {city}, {region}, {country}";
    }
}
