
public class Bicycles : Activity
{
    private double _speed;
    public Bicycles(int time, double speed) : base(time, "Bicycle")
    {
        _speed = speed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetDistance()
    {
        double distance = _time * _speed / 60.0;
        return distance;
    }
    public override double GetPace()
    {
        double pace = 60.0 / GetSpeed();
        return pace;
    }
    
}