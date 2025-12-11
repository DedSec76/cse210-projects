
public class Running : Activity
{
    private double _distance;
    public Running(int time, double distance) : base(time, "Running")
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        double speed = GetDistance() / _time * 60.0;
        return speed;
    }
    public override double GetPace()
    {
        double pace = _time / GetDistance();
        return pace;
    }
}