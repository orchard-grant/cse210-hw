class Program
{
    static void Main(string[] args)
    {
        // Create an address and lecture event
        Address _lectureAddress = new Address("1600 Amphitheatre Pkwy", "Mountain View", "CA", "94043");
        Event _lecture = new Lecture("AI Revolution", "Exploring advancements in artificial intelligence", DateTime.Now.AddDays(15), "9:00 AM", _lectureAddress, "Dr. Jane Smith", 200);

        // Create an address and reception event
        Address _receptionAddress = new Address("123 Elm St", "Chicago", "IL", "60601");
        Event _reception = new Reception("Annual Gala", "A formal gathering to celebrate company achievements", DateTime.Now.AddDays(25), "7:30 PM", _receptionAddress, "rsvp@annualgala.com");

        // Create an address and outdoor gathering event
        Address _outdoorAddress = new Address("500 Lake Shore Dr", "Seattle", "WA", "98109");
        Event _outdoor = new OutdoorGathering("Music in the Park", "An evening of live music performances", DateTime.Now.AddDays(35), "6:00 PM", _outdoorAddress, "Clear skies");

        // Store all events in an array
        Event[] _events = { _lecture, _reception, _outdoor };

        // Loop through each event and display its details
        foreach (Event evt in _events)
        {
            Console.WriteLine(evt.GetStandardDetails()); // Display standard details
            Console.WriteLine();
            Console.WriteLine(evt.GetFullDetails()); // Display full details
            Console.WriteLine();
            Console.WriteLine(evt.GetShortDescription()); // Display short description
            Console.WriteLine("-----------------------------------------------------");
        }
    }
}
