using System;

public class Activity
{
    private string _activity;
    private double _minutes;

    public Activity(string activity, double minutes)
    {
        _activity = activity;
        _minutes = minutes;
    }

    public string GetActivity()
    {
        return _activity;
    }

    public double GetMinutes()
    {
        return _minutes;
    }
    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public virtual string GetSummary()
    {
        return $"{DateTime.Now:dd MMM yyyy} {GetActivity()} ({GetMinutes()} min): Distance: {GetDistance():F2} km, Speed: {GetSpeed():F2} kph, Pace: {GetPace():F2} min/km";
    }
}