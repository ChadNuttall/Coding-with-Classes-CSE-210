public class Swimming : Activity
{
    private double _laps;

    public Swimming(string date, double length, double laps) : base(date, length)
    {
        _laps = laps;
    }

    public override double CalculateDistance()
    {
        return _laps * 50 / 1000;
    }

    public override double CalculateSpeed()
    {
        return (_laps * 50 / 1000) / (GetLength() / 60);
    }

    public override double CalculatePace()
    {
        return (GetLength() / 60) / (_laps * 50 / 1000);
    }

    public override string GetSummary()
    {
        return base.GetSummary() + $"Swimming ({GetLength()} min): Distance {CalculateDistance():0.0} km, Speed: {CalculateSpeed():0.0} kph, Pace: {CalculatePace():0.00} min per km";
    }
}