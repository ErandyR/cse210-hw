using System;

public class RunningActivity : Activity
{
    private double _distance;
    public RunningActivity(string activity, int distance, int minutes) : base(activity, minutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / GetMinutes()) * 60;
    }

    public override double GetPace()
    {
        return GetMinutes() / _distance;
    }

}