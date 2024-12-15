public class Lecture : Event
{
    // Fields specific to a lecture
    private string _speaker;
    private int _capacity;

    // Constructor to initialize lecture details
    public Lecture(string title, string description, DateTime date, string time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address)
    {
        this._speaker = speaker;
        this._capacity = capacity;
    }

    // Override to get full details of the lecture
    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nEvent Type: Lecture\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }
}
