public class Running : Exercise
{
    // Field to store the running distance
    private double _distance;

    // Constructor to initialize running details
    public Running(string date, int minutes, double distance) : base(date, minutes)
    {
        _distance = distance;
    }

    // Calculate the running distance (in km)
    public override double CalculateDistance()
    {
        return _distance;
    }

    // Calculate the speed (in km/h)
    public override double CalculateSpeed()
    {
        return (_distance / Minutes) * 60;
    }

    // Calculate the pace (in minutes per km)
    public override double CalculatePace()
    {
        return Minutes / _distance;
    }
}
