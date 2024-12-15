public class Swimming : Exercise
{
    // Field to store the number of laps
    private int _laps;

    // Constructor to initialize swimming details
    public Swimming(string date, int minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }

    // Calculate the distance (in km) based on the number of laps
    public override double CalculateDistance()
    {
        return _laps * 50 / 1000.0; // Each lap is 50 meters, converted to kilometers
    }

    // Calculate the speed (in km/h)
    public override double CalculateSpeed()
    {
        return (CalculateDistance() / Minutes) * 60;
    }

    // Calculate the pace (in minutes per km)
    public override double CalculatePace()
    {
        return Minutes / CalculateDistance();
    }
}
