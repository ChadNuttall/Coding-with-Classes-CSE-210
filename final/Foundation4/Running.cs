public class Running : Activity
{
    private double _distance;

    public Running(string date, double length, double distance) : base(date, length)
    {
        _distance = distance;
    }

    public override double CalculateDistance()
    {
        return _distance;
    }

    public override double CalculateSpeed()
    {
        return (_distance / GetLength()) * 60;
    }

    public override double CalculatePace()
    {
        return GetLength() / _distance;
    }

    public override string GetSummary()
    {
        return base.GetSummary() + $"Running ({GetLength()} min)- Distance {_distance} miles, Speed {CalculateSpeed():0.0} mph, Pace: {CalculatePace():0.00} min per mile";
    }
}