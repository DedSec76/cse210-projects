
public class Swimming : Activity
{
    private int _laps;
    public Swimming(int time, int laps) : base(time, "Swimming")
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        double distance = _laps * 50.0 / 1000.0;
        return distance;
    }
    public override double GetSpeed()
    {
        double speed = GetDistance() / _time * 60.0;
        return speed;
    }
    public override double GetPace()
    {
        double pace = (double)_time / GetDistance();
        return pace;
    }
    
}