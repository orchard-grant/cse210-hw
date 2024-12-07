public class Customer
{
    private string fullName;
    private Address homeAddress;

    public Customer(string fullName, Address homeAddress)
    {
        this.fullName = fullName;
        this.homeAddress = homeAddress;
    }

    public string FullName => fullName;
    public Address HomeAddress => homeAddress;

    public bool ResidesInUSA()
    {
        return homeAddress.LocatedInUSA();
    }
}
