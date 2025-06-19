using System;

public class SwimmingActivity : Activity
{
    private double _laps;
    public SwimmingActivity(string activity, double laps, double minutes) : base(activity, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {

        return _laps * 50 / 1000;
    }
    public override double GetSpeed()
    {
        return (GetDistance() / GetMinutes()) * 60;
    }

    public override double GetPace()
    {
        return GetMinutes() / GetDistance();
    }
}