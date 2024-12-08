public class Customer
{
    private string _fullName;
    private Address _homeAddress;

    public Customer(string fullName, Address homeAddress)
    {
        _fullName = fullName;
        _homeAddress = homeAddress;
    }

    public string GetFullName() => _fullName;
    public Address GetHomeAddress() => _homeAddress;

    public bool ResidesInUSA()
    {
        return _homeAddress.LocatedInUSA();
    }
}
