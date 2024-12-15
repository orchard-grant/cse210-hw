public abstract class Event
{
    // Private fields for event details
    private string _title;
    private string _description;
    private DateTime _date;
    private string _time;
    private Address _address;

    // Constructor to initialize event details
    public Event(string title, string description, DateTime date, string time, Address address)
    {
        this._title = title;
        this._description = description;
        this._date = date;
        this._time = time;
        this._address = address;
    }

    // Get basic event details
    public virtual string GetStandardDetails()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date.ToShortDateString()}\nTime: {_time}\nAddress: {_address}";
    }

    // Abstract method for full details
    public abstract string GetFullDetails();
    
    // Get a short event description
    public string GetShortDescription()
    {
        return $"Event Type: {this.GetType().Name}\nTitle: {_title}\nDate: {_date.ToShortDateString()}";
    }
}
