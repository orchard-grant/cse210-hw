public class StationaryBicycles : Exercise
{
    // Field to store the speed (in km/h)
    private double _speed;

    // Constructor to initialize stationary bicycle details
    public StationaryBicycles(string date, int minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
    }

    // Calculate the distance (in km) based on speed and time
    public override double CalculateDistance()
    {
        return _speed * Minutes / 60;
    }

    // Return the speed (in km/h)
    public override double CalculateSpeed()
    {
        return _speed;
    }

    // Calculate the pace (in minutes per km)
    public override double CalculatePace()
    {
        return 60 / _speed;
    }
}
