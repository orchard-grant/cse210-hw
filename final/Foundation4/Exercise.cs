public abstract class Exercise
{
    // Fields to store the exercise date and duration
    private string _date;
    private int _minutes;

    // Constructor to initialize the exercise details
    public Exercise(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    // Properties to access the date and minutes
    public string Date => _date;
    public int Minutes => _minutes;

    // Abstract methods for distance, speed, and pace calculations
    public abstract double CalculateDistance();
    public abstract double CalculateSpeed();
    public abstract double CalculatePace();

    // Method to generate a summary of the exercise
    public virtual string GetSummary()
    {
        string summary = $"{_date} {this.GetType().Name} ({_minutes} min) - Distance: {CalculateDistance():F2} km, Speed: {CalculateSpeed():F2} kph, Pace: {CalculatePace():F2} min per km";
        return summary;
    }
}
