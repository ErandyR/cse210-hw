using System;

public class CyclingActivity : Activity
{
    private double _speed;
    public CyclingActivity(string activity, double speed, double minutes) : base(activity, minutes)
    {
        _speed = speed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetDistance()
    {
        return (_speed * GetMinutes()) / 60.0;
    }

    public override double GetPace()
    {
        return GetMinutes() / GetDistance();
    }
}