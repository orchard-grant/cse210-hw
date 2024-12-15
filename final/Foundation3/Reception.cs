public class Reception : Event
{
    // Field for the RSVP email
    private string _rsvpEmail;

    // Constructor to initialize reception details
    public Reception(string title, string description, DateTime date, string time, Address address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        this._rsvpEmail = rsvpEmail;
    }

    // Override to get full details of the reception
    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nEvent Type: Reception\nRSVP Email: {_rsvpEmail}";
    }
}
