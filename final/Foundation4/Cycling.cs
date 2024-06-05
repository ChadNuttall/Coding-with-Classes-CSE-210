public class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, double length, double speed) : base(date, length)
    {
        _speed = speed;
    }

    public override double CalculateDistance()
    {
        return CalculateSpeed() * GetLength() / 60;
    }

    public override double CalculateSpeed()
    {
        return _speed;
    }

    public override double CalculatePace()
    {
        return 60 / _speed;
    }

    public override string GetSummary()
    {
        return base.GetSummary() + $"Cycling ({GetLength()} min)- Distance {CalculateDistance():0.0} km, Speed: {_speed} kph, Pace: {CalculatePace():0.00} min per km";
    }
}