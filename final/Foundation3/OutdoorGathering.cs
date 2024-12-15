public class OutdoorGathering : Event
{
    // Field for the weather forecast
    private string _weatherForecast;

    // Constructor to initialize outdoor gathering details
    public OutdoorGathering(string title, string description, DateTime date, string time, Address address, string weatherForecast)
        : base(title, description, date, time, address)
    {
        this._weatherForecast = weatherForecast;
    }

    // Override to get full details of the outdoor gathering
    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nEvent Type: Outdoor Gathering\nWeather Forecast: {_weatherForecast}";
    }
}
