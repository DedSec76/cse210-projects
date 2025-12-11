
public abstract class Activity
{
    protected DateTime _dateNow;
    protected int _time;
    protected string _activity;

    public Activity(int time, string activity)
    {
        _dateNow = DateTime.Now;
        _time = time;
        _activity = activity;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // Method Get Sumary
    public virtual string GetSumary()
    {
        return $"{_dateNow.ToShortDateString()} {_activity} ({_time} min) - Distance {Math.Round(GetDistance(), 2)} km, Speed {Math.Round(GetSpeed(), 2)} kph, Pace: {Math.Round(GetPace(), 2)} min per km\n";
    }
}